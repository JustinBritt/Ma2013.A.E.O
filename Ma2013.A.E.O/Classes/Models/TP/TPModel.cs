namespace Ma2013.A.E.O.Classes.Models.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Models.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    internal sealed class TPModel : ITPModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPModel(
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
            ITPInputContext TPInputContext)
        {
            this.TPInputContext = TPInputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // a
            this.a = indicesAbstractFactory.CreateaFactory().Create(
                this.TPInputContext.ActiveDays
                .Select(x => indexElementsAbstractFactory.CreateaIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // d
            this.d = indicesAbstractFactory.CreatedFactory().Create(
                this.TPInputContext.Days
                .Select(x => indexElementsAbstractFactory.CreatedIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // k
            this.k = indicesAbstractFactory.CreatekFactory().Create(
                this.TPInputContext.BlockTypes
                .Select(x => indexElementsAbstractFactory.CreatekIndexElementFactory().Create(x))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                this.TPInputContext.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create(x))
                .ToImmutableList());

            // p
            this.p = indicesAbstractFactory.CreatepFactory().Create(
                this.TPInputContext.PatientGroups
                .Select(x => indexElementsAbstractFactory.CreatepIndexElementFactory().Create(x))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                this.TPInputContext.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.TPInputContext.SurgeonGroups
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // w
            this.w = indicesAbstractFactory.CreatewFactory().Create(
                this.TPInputContext.Wards
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatewIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // ar
            this.ar = crossJoinsAbstractFactory.CreatearFactory().Create(
                this.a.Value
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatearCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // pa
            this.pa = crossJoinsAbstractFactory.CreatepaFactory().Create(
                this.p.Value
                .SelectMany(b => this.a.Value, (a, b) => crossJoinElementsAbstractFactory.CreatepaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rk
            this.rk = crossJoinsAbstractFactory.CreaterkFactory().Create(
                this.r.Value
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreaterkCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sa
            this.sa = crossJoinsAbstractFactory.CreatesaFactory().Create(
                this.s.Value
                .SelectMany(b => this.a.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sark
            this.sark = crossJoinsAbstractFactory.CreatesarkFactory().Create(
                this.s.Value
                .SelectMany(b => this.a.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesaCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.r.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesarCrossJoinElementFactory().Create(a.sIndexElement, a.aIndexElement, b))
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreatesarkCrossJoinElementFactory().Create(a.sIndexElement, a.aIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // sk
            this.sk = crossJoinsAbstractFactory.CreateskFactory().Create(
                this.s.Value
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreateskCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // wd
            this.wd = crossJoinsAbstractFactory.CreatewdFactory().Create(
                this.w.Value
                .SelectMany(b => this.d.Value, (a, b) => crossJoinElementsAbstractFactory.CreatewdCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // BEDS
            this.BEDS = parametersAbstractFactory.CreateBEDSFactory().Create(
                this.TPInputContext.NumberBeds);

            // dur(p)
            this.dur = parametersAbstractFactory.CreatedurFactory().Create(
                this.TPInputContext.PatientGroupSurgeryDurations
                .Select(x => parameterElementsAbstractFactory.CreatedurParameterElementFactory().Create(
                    this.p.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // Length(k)
            this.Length = parametersAbstractFactory.CreateLengthFactory().Create(
                this.TPInputContext.BlockTypeTimeBlockLengths
                .Select(x => parameterElementsAbstractFactory.CreateLengthParameterElementFactory().Create(
                    this.k.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // ORday(a, r)
            this.ORday = parametersAbstractFactory.CreateORdayFactory().Create(
                this.TPInputContext.DayOperatingRoomOperatingCapacities
                .Select(x => parameterElementsAbstractFactory.CreateORdayParameterElementFactory().Create(
                    this.a.GetElementAt(x.Item1),
                    this.r.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // P(s)
            this.Ps = parametersAbstractFactory.CreatePsFactory().Create(
                this.TPInputContext.SurgeonGroupSubsetPatientGroups
                .Select(x => parameterElementsAbstractFactory.CreatePsParameterElementFactory().Create(
                    this.s.GetElementAt(x.Key),
                    this.p.GetElementAt(x.Value)))
                .ToImmutableList());

            // P(w)
            this.Pw = parametersAbstractFactory.CreatePwFactory().Create(
                this.TPInputContext.WardSubsetPatientGroups
                .Select(x => parameterElementsAbstractFactory.CreatePwParameterElementFactory().Create(
                    this.w.GetElementAt(x.Key),
                    this.p.GetElementAt(x.Value)))
                .ToImmutableList());

            // prob(p, l)
            this.prob = parametersAbstractFactory.CreateprobFactory().Create(
                this.TPInputContext.PatientGroupDayLengthOfStayProbabilities
                .Select(x => parameterElementsAbstractFactory.CreateprobParameterElementFactory().Create(
                    this.p.GetElementAt(x.Item1),
                    this.l.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // THR(p)
            this.THR = parametersAbstractFactory.CreateTHRFactory().Create(
                this.TPInputContext.PatientGroupThroughputs
                .Select(x => parameterElementsAbstractFactory.CreateTHRParameterElementFactory().Create(
                    this.p.GetElementAt(x.Key),
                    x.Value))
                .ToImmutableList());

            // W
            this.W = parametersAbstractFactory.CreateWFactory().Create(
                this.TPInputContext.Wards
                .Select(x => parameterElementsAbstractFactory.CreateWParameterElementFactory().Create(
                    this.w.GetElementAt(x.Item1),
                    x.Item2.Select(i => this.s.GetElementAt(i)).ToImmutableList()))
                .ToImmutableList());

            // α(w)
            this.α = parametersAbstractFactory.CreateαFactory().Create(
                this.TPInputContext.Wardα
                .Select(x => parameterElementsAbstractFactory.CreateαParameterElementFactory().Create(
                    this.w.GetElementAt(x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

            // β(w)
            this.β = parametersAbstractFactory.CreateβFactory().Create(
                this.TPInputContext.Wardβ
                .Select(x => parameterElementsAbstractFactory.CreateβParameterElementFactory().Create(
                    this.w.GetElementAt(x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

            // γ(w)
            this.γ = parametersAbstractFactory.CreateγFactory().Create(
                this.TPInputContext.Wardγ
                .Select(x => parameterElementsAbstractFactory.CreateγParameterElementFactory().Create(
                    this.w.GetElementAt(x.Key),
                    (FhirDecimal)x.Value))
                .ToImmutableList());

            // Variables

            // x(p, a)
            this.x = variablesAbstractFactory.CreateTPxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.p.Value, 
                    indexSet2: this.a.Value,
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => int.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Integer));

            // y(w)
            this.y = variablesAbstractFactory.CreateTPyFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => int.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Integer)); 

            // z(s, a, r, k)
            this.z = variablesAbstractFactory.CreateTPzFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value, 
                    indexSet2: this.a.Value, 
                    indexSet3: this.r.Value, 
                    indexSet4: this.k.Value, 
                    lowerBoundGenerator: (a, b, c, d) => 0,
                    upperBoundGenerator: (a, b, c, d) => 1, 
                    variableTypeGenerator: (a, b, c, d) => VariableType.Binary)); 

            // δMinus(w, d)
            this.δMinus = variablesAbstractFactory.CreateδMinusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    indexSet2: this.d.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // δPlus(w)
            this.δPlus_w = variablesAbstractFactory.CreateδPluswFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous));

            // δPlus(w, d)
            this.δPlus_wd = variablesAbstractFactory.CreateδPluswdFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    indexSet2: this.d.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // μ(w, d)
            this.μ = variablesAbstractFactory.CreateμFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    indexSet2: this.d.Value, 
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => double.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // Variance(w)
            this.Variance_w = variablesAbstractFactory.CreateVariancewFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    lowerBoundGenerator: (a) => 0,
                    upperBoundGenerator: (a) => double.MaxValue,
                    variableTypeGenerator: (a) => VariableType.Continuous));

            // Variance(w, d)
            this.Variance_wd = variablesAbstractFactory.CreateVariancewdFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value, 
                    indexSet2: this.d.Value, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // Constraints

            // Constraint (2′′)
            this.Model.AddConstraint(
                constraintsAbstractFactory.CreateTPConstraint2Factory().Create(
                    this.w,
                    this.BEDS,
                    this.y)
                .Value);

            // Constraints (9′)
            this.Model.AddConstraints(
                this.p.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints9ConstraintElementFactory().Create(
                        i,
                        this.a,
                        this.THR,
                        this.x)
                    .Value));

            // Constraints (11)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints11ConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.d,
                        this.l,
                        this.pa,
                        this.Pw,
                        this.prob,
                        this.x,
                        this.μ)
                    .Value));

            // Constraints (12)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints12ConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.d,
                        this.l,
                        this.pa,
                        this.Pw,
                        this.prob,
                        this.x,
                        this.Variance_wd)
                    .Value));

            // Constraints (13L)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints13LConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.y,
                        this.δMinus,
                        this.μ)
                    .Value));

            // Constraints (13M)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints13MConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.y,
                        this.δPlus_wd,
                        this.μ)
                    .Value));

            // Constraints (13U)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints13UConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.δPlus_w,
                        this.δPlus_wd)
                    .Value));

            // Constraints (14)
            this.Model.AddConstraints(
                this.wd.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints14ConstraintElementFactory().Create(
                        i.dIndexElement,
                        i.wIndexElement,
                        this.Variance_w,
                        this.Variance_wd)
                    .Value));

            // Constraints (15)
            this.Model.AddConstraints(
                this.ar.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints15ConstraintElementFactory().Create(
                        i.aIndexElement,
                        i.rIndexElement,
                        this.sk,
                        this.Length,
                        this.ORday,
                        this.z)
                    .Value));

            // Constraints (16)
            this.Model.AddConstraints(
                this.sa.Value
                .Select(
                    i => constraintElementsAbstractFactory.CreateConstraints16ConstraintElementFactory().Create(
                        i.aIndexElement,
                        i.sIndexElement,
                        this.p,
                        this.rk,
                        this.dur,
                        this.Length,
                        this.Ps,
                        this.x,
                        this.z)
                    .Value));

            // Objective Function (10)
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateTPObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.d,
                    this.w,
                    this.α,
                    this.β,
                    this.γ,
                    this.δMinus,
                    this.δPlus_w,
                    this.Variance_w)
                .Value);
        }

        /// <summary>
        /// Gets the Context instance.
        /// </summary>
        public ITPInputContext TPInputContext { get; }

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
        /// Gets the index set for block types.
        /// </summary>
        public Ik k { get; }

        /// <summary>
        /// Gets the index set for length of stay days.
        /// </summary>
        public Il l { get; }

        /// <summary>
        /// Gets the index set for patient groups.
        /// </summary>
        public Ip p { get; }

        /// <summary>
        /// Gets the index set for operating rooms.
        /// </summary>
        public Ir r { get; }

        /// <summary>
        /// Gets the index set for surgeon groups.
        /// </summary>
        public Is s { get; }

        /// <summary>
        /// Gets the index set for wards.
        /// </summary>
        public Iw w { get; }

        public Iar ar { get; }

        public Ipa pa { get; }

        public Irk rk { get; }

        public Isa sa { get; }

        public Isark sark { get; }

        public Isk sk { get; }

        public Iwd wd { get; }

        public IBEDS BEDS { get; }

        public Idur dur { get; }

        public ILength Length { get; }

        public IORday ORday { get; }

        public Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups.IP Ps { get; }

        public Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups.IP Pw { get; }

        public Iprob prob { get; }

        public ITHR THR { get; }

        public IW W { get; }

        public Iα α { get; }

        public Iβ β { get; }

        public Iγ γ { get; }

        public ITPx x { get; }

        public ITPy y { get; }

        public ITPz z { get; }

        public IδMinus δMinus { get; }

        public Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w { get; }

        public Interfaces.Variables.TP.WardDayBedAvailabilityDeviations.IδPlus δPlus_wd { get; }

        public Iμ μ { get; }

        public Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w { get; }

        public Interfaces.Variables.TP.WardDayBedRequirementVariances.IVariance Variance_wd { get; }
    }
}