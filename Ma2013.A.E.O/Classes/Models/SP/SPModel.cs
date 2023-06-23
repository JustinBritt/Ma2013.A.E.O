namespace Ma2013.A.E.O.Classes.Models.SP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.Patterns.Visitor;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Models.SP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.SP;
    using NGenerics.DataStructures.Trees;

    internal sealed class SPModel : ISPModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPModel(
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            ISPInputContext SPInputContext)
        {
            this.SPInputContext = SPInputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // a
            this.a = indicesAbstractFactory.CreateaFactory().Create(
                this.SPInputContext.ActiveDays
                .Select(x => indexElementsAbstractFactory.CreateaIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // d
            this.d = indicesAbstractFactory.CreatedFactory().Create(
                this.SPInputContext.Days
                .Select(x => indexElementsAbstractFactory.CreatedIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // p
            this.p = indicesAbstractFactory.CreatepFactory().Create(
                this.SPInputContext.PatientGroups
                .Select(x => indexElementsAbstractFactory.CreatepIndexElementFactory().Create(x))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.SPInputContext.SurgeonGroups
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // w
            this.w = indicesAbstractFactory.CreatewFactory().Create(
                this.SPInputContext.Wards
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatewIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // pa
            this.pa = crossJoinsAbstractFactory.CreatepaFactory().Create(
                this.p.Value
                .SelectMany(b => this.a.Value, (a, b) => crossJoinElementsAbstractFactory.CreatepaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sa
            this.sa = crossJoinsAbstractFactory.CreatesaFactory().Create(
                this.s.Value
                .SelectMany(b => this.a.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // wd
            this.wd = crossJoinsAbstractFactory.CreatewdFactory().Create(
                this.w.Value
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreatewdCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // A(p, d)
            this.A = parametersAbstractFactory.CreateAFactory().Create(
                this.SPInputContext.PatientGroupDaySubsetActiveDays
                .Select(x => parameterElementsAbstractFactory.CreateAParameterElementFactory().Create(
                    this.p.GetElementAt(x.Item1),
                    this.d.GetElementAt(x.Item2),
                    this.a.GetElementAt(x.Item3)))
                .ToImmutableList());

            // BEDS
            this.BEDS = parametersAbstractFactory.CreateBEDSFactory().Create(
                this.SPInputContext.NumberBeds);

            // BLOCKS
            this.BLOCKS = parametersAbstractFactory.CreateBLOCKSFactory().Create(
                this.SPInputContext.NumberBlocks);

            // dur(p)
            this.dur = parametersAbstractFactory.CreatedurFactory().Create(
                this.SPInputContext.PatientGroupSurgeryDurations
                .Select(x => parameterElementsAbstractFactory.CreatedurParameterElementFactory().Create(
                    this.p.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // LB(p)
            IPatientGroupNumberPatientLowerBoundsVisitor<INullableValue<int>, INullableValue<int>> patientGroupNumberPatientLowerBoundsVisitor = new Ma2013.A.E.O.Visitors.Contexts.SP.PatientGroupNumberPatientLowerBoundsVisitor<INullableValue<int>, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateLBParameterElementFactory(),
                this.p);

            this.SPInputContext.PatientGroupNumberPatientLowerBounds.AcceptVisitor(
                patientGroupNumberPatientLowerBoundsVisitor);

            this.LB = parametersAbstractFactory.CreateLBFactory().Create(
                patientGroupNumberPatientLowerBoundsVisitor.RedBlackTree);

            // LENGTH
            this.LENGTH = parametersAbstractFactory.CreateLENGTHFactory().Create(
                this.SPInputContext.TimeBlockLength);

            // P(s)
            this.Ps = parametersAbstractFactory.CreatePsFactory().Create(
                this.SPInputContext.SurgeonGroupSubsetPatientGroups
                .Select(x => parameterElementsAbstractFactory.CreatePsParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    this.p.GetElementAt(x.Value)))
                .ToImmutableList());

            // P(w)
            this.Pw = parametersAbstractFactory.CreatePwFactory().Create(
                this.SPInputContext.WardSubsetPatientGroups
                .Select(x => parameterElementsAbstractFactory.CreatePwParameterElementFactory().Create(
                    this.w.GetElementAt(x.Key),
                    this.p.GetElementAt(x.Value)))
                .ToImmutableList());

            // r(p)
            IPatientGroupProfitsVisitor<INullableValue<int>, Money> patientGroupProfitsVisitor = new Ma2013.A.E.O.Visitors.Contexts.SP.PatientGroupProfitsVisitor<INullableValue<int>, Money>(
                parameterElementsAbstractFactory.CreaterParameterElementFactory(),
                this.p);

            this.SPInputContext.PatientGroupProfits.AcceptVisitor(
                patientGroupProfitsVisitor);

            this.r = parametersAbstractFactory.CreaterFactory().Create(
                patientGroupProfitsVisitor.RedBlackTree);

            // UB(p)
            this.UB = parametersAbstractFactory.CreateUBFactory().Create(
                this.SPInputContext.PatientGroupNumberPatientUpperBounds
                .Select(x => parameterElementsAbstractFactory.CreateUBParameterElementFactory().Create(
                    this.p.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // Variables

            // x(p, a)
            this.x = variablesAbstractFactory.CreateSPxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.p.Value,
                    indexSet2: this.a.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: null, 
                    variableTypeGenerator: (a, b) => VariableType.Integer));

            // y(w)
            this.y = variablesAbstractFactory.CreateSPyFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value,
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: null, 
                    variableTypeGenerator: (a) => VariableType.Integer)); 

            // z(s, a)
            this.z = variablesAbstractFactory.CreateSPzFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.a.Value, 
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: null, 
                    variableTypeGenerator: (a, b) => VariableType.Integer)); 

            // Constraints (2)
            this.Model.AddConstraint(
                constraintsAbstractFactory.CreateSPConstraint2Factory().Create(
                    this.w,
                    this.BEDS,
                    this.y)
                .Value);

            // Constraints (3)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints3ConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.pa,
                        this.A,
                        this.Pw,
                        this.x,
                        this.y)
                    .Value));

            // Constraints (4)
            this.Model.AddConstraints(
                this.a.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        i,
                        this.s,
                        this.BLOCKS,
                        this.z)
                    .Value));

            // Constraints (5)
            this.Model.AddConstraints(
                this.sa.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints5ConstraintElementFactory().Create(
                        i.aIndexElement,
                        i.sIndexElement,
                        this.p,
                        this.dur,
                        this.LENGTH,
                        this.Ps,
                        this.x,
                        this.z)
                    .Value));

            // Constraints (6L)
            this.Model.AddConstraints(
                this.p.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints6LConstraintElementFactory().Create(
                        i,
                        this.a,
                        this.LB,
                        this.x)
                    .Value));

            // Constraints (6U)
            this.Model.AddConstraints(
                this.p.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints6UConstraintElementFactory().Create(
                        i,
                        this.a,
                        this.UB,
                        this.x)
                    .Value));

            // Objective Function (1)
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateSPObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.pa,
                    this.r,
                    this.x)
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public ISPInputContext SPInputContext { get; }

        /// <summary>
        /// Gets the Model instance
        /// </summary>
        public Model Model { get; }

        /// <summary>
        /// Gets the index set for active days.
        /// </summary>
        public Ia a { get; }

        /// <summary>
        /// Gets the index set for days.
        /// </summary>
        public Ma2013.A.E.O.Interfaces.Indices.Common.Id d { get; }

        /// <summary>
        /// Gets the index set for patient groups.
        /// </summary>
        public Ip p { get; }

        /// <summary>
        /// Gets the index set for surgeon groups.
        /// </summary>
        public Is s { get; }

        /// <summary>
        /// Gets the index set for wards.
        /// </summary>
        public Iw w { get; }

        public Ipa pa { get; }

        public Isa sa { get; }

        public Iwd wd { get; }

        public IA A { get; }

        public IBEDS BEDS { get; }

        public IBLOCKS BLOCKS { get; }

        public Idur dur { get; }

        public ILB LB { get; }

        public ILENGTH LENGTH { get; }

        public Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups.IP Ps { get; }

        public Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups.IP Pw { get; }

        public Ir r { get; }

        public IUB UB { get; }

        public ISPx x { get; }

        public ISPy y { get; }

        public ISPz z { get; }
    }
}