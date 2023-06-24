namespace Ma2013.A.E.O.Classes.Models.SP
{
    using System;
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
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.Common;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.SP;

    internal sealed class SPModel : ISPModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPModel(
            IComparersAbstractFactory comparersAbstractFactory,
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
            IActiveDaysVisitor<INullableValue<int>, FhirDateTime> activeDaysVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.ActiveDaysVisitor<INullableValue<int>, FhirDateTime>(
                indexElementsAbstractFactory.CreateaIndexElementFactory(),
                new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

            this.SPInputContext.ActiveDays.AcceptVisitor(
                activeDaysVisitor);

            this.a = indicesAbstractFactory.CreateaFactory().Create(
                activeDaysVisitor.RedBlackTree);

            // d
            IDaysVisitor<INullableValue<int>, FhirDateTime> daysVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.DaysVisitor<INullableValue<int>, FhirDateTime>(
                indexElementsAbstractFactory.CreatedIndexElementFactory(),
                new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

            this.SPInputContext.Days.AcceptVisitor(
                daysVisitor);

            this.d = indicesAbstractFactory.CreatedFactory().Create(
                daysVisitor.RedBlackTree);

            // p
            this.p = indicesAbstractFactory.CreatepFactory().Create(
                new Ma2013.A.E.O.Classes.Comparers.NullableValueintComparer(),
                this.SPInputContext.PatientGroups
                .Select(x => indexElementsAbstractFactory.CreatepIndexElementFactory().Create(x))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer(),
                this.SPInputContext.SurgeonGroups
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // w
            this.w = indicesAbstractFactory.CreatewFactory().Create(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer(),
                this.SPInputContext.Wards
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatewIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // pa
            this.pa = crossJoinsAbstractFactory.CreatepaFactory().Create(
                this.p.Value.Values
                .SelectMany(b => this.a.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatepaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sa
            this.sa = crossJoinsAbstractFactory.CreatesaFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.a.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // wd
            this.wd = crossJoinsAbstractFactory.CreatewdFactory().Create(
                this.w.Value.Values
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatewdCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // A(p, d)
            IPatientGroupDaySubsetActiveDaysVisitor<Tuple<INullableValue<int>, FhirDateTime>, ImmutableSortedSet<FhirDateTime>> patientGroupDaySubsetActiveDaysVisitor = new Ma2013.A.E.O.Visitors.Contexts.SP.PatientGroupDaySubsetActiveDaysVisitor<Tuple<INullableValue<int>, FhirDateTime>, ImmutableSortedSet<FhirDateTime>>(
                parameterElementsAbstractFactory.CreateAParameterElementFactory(),
                this.a,
                this.d,
                this.p,
                this.pa);

            this.SPInputContext.PatientGroupDaySubsetActiveDays.AcceptVisitor(
                patientGroupDaySubsetActiveDaysVisitor);

            this.A = parametersAbstractFactory.CreateAFactory().Create(
                patientGroupDaySubsetActiveDaysVisitor.RedBlackTree);

            // BEDS
            this.BEDS = parametersAbstractFactory.CreateBEDSFactory().Create(
                this.SPInputContext.NumberBeds);

            // BLOCKS
            this.BLOCKS = parametersAbstractFactory.CreateBLOCKSFactory().Create(
                this.SPInputContext.NumberBlocks);

            // dur(p)
            IPatientGroupSurgeryDurationsVisitor<INullableValue<int>, Duration> patientGroupSurgeryDurationsVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.PatientGroupSurgeryDurationsVisitor<INullableValue<int>, Duration>(
                parameterElementsAbstractFactory.CreatedurParameterElementFactory(),
                this.p);

            this.SPInputContext.PatientGroupSurgeryDurations.AcceptVisitor(
                patientGroupSurgeryDurationsVisitor);

            this.dur= parametersAbstractFactory.CreatedurFactory().Create(
                patientGroupSurgeryDurationsVisitor.RedBlackTree);

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
            ISurgeonGroupSubsetPatientGroupsVisitor<Organization, INullableValue<int>> surgeonGroupSubsetPatientGroupsVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.SurgeonGroupSubsetPatientGroupsVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreatePsParameterElementFactory(),
                this.p,
                this.s);

            this.SPInputContext.SurgeonGroupSubsetPatientGroups.AcceptVisitor(
                surgeonGroupSubsetPatientGroupsVisitor);

            this.Ps = parametersAbstractFactory.CreatePsFactory().Create(
                surgeonGroupSubsetPatientGroupsVisitor.RedBlackTree);

            // P(w)
            IWardSubsetPatientGroupsVisitor<Organization, INullableValue<int>> wardSubsetPatientGroupsVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.WardSubsetPatientGroupsVisitor<Organization, INullableValue<int>>(
                parameterElementsAbstractFactory.CreatePwParameterElementFactory(),
                this.p,
                this.w);

            this.SPInputContext.WardSubsetPatientGroups.AcceptVisitor(
                wardSubsetPatientGroupsVisitor);

            this.Pw = parametersAbstractFactory.CreatePwFactory().Create(
                wardSubsetPatientGroupsVisitor.RedBlackTree);

            // r(p)
            IPatientGroupProfitsVisitor<INullableValue<int>, Money> patientGroupProfitsVisitor = new Ma2013.A.E.O.Visitors.Contexts.SP.PatientGroupProfitsVisitor<INullableValue<int>, Money>(
                parameterElementsAbstractFactory.CreaterParameterElementFactory(),
                this.p);

            this.SPInputContext.PatientGroupProfits.AcceptVisitor(
                patientGroupProfitsVisitor);

            this.r = parametersAbstractFactory.CreaterFactory().Create(
                patientGroupProfitsVisitor.RedBlackTree);

            // UB(p)
            IPatientGroupNumberPatientUpperBoundsVisitor<INullableValue<int>, INullableValue<int>> patientGroupNumberPatientUpperBoundsVisitor = new Ma2013.A.E.O.Visitors.Contexts.SP.PatientGroupNumberPatientUpperBoundsVisitor<INullableValue<int>, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateUBParameterElementFactory(),
                this.p);

            this.SPInputContext.PatientGroupNumberPatientUpperBounds.AcceptVisitor(
                patientGroupNumberPatientUpperBoundsVisitor);

            this.UB = parametersAbstractFactory.CreateUBFactory().Create(
                patientGroupNumberPatientUpperBoundsVisitor.RedBlackTree);

            // Variables

            // x(p, a)
            this.x = variablesAbstractFactory.CreateSPxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.p.Value.Values,
                    indexSet2: this.a.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: null, 
                    variableTypeGenerator: (a, b) => VariableType.Integer));

            // y(w)
            this.y = variablesAbstractFactory.CreateSPyFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values,
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: null, 
                    variableTypeGenerator: (a) => VariableType.Integer)); 

            // z(s, a)
            this.z = variablesAbstractFactory.CreateSPzFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.a.Value.Values, 
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
                this.a.Value.Values
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
                this.p.Value.Values
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints6LConstraintElementFactory().Create(
                        i,
                        this.a,
                        this.LB,
                        this.x)
                    .Value));

            // Constraints (6U)
            this.Model.AddConstraints(
                this.p.Value.Values
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