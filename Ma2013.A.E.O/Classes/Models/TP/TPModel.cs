namespace Ma2013.A.E.O.Classes.Models.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.Patterns.Visitor;

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
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.Common;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;
    using Ma2013.A.E.O.Visitors.Contexts.TP;
    using NGenerics.DataStructures.Trees;

    internal sealed class TPModel : ITPModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPModel(
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
            ITPInputContext TPInputContext)
        {
            this.TPInputContext = TPInputContext;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices

            // a
            IActiveDaysVisitor<INullableValue<int>, FhirDateTime> activeDaysVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.ActiveDaysVisitor<INullableValue<int>, FhirDateTime>(
                indexElementsAbstractFactory.CreateaIndexElementFactory(),
                comparersAbstractFactory.CreateFhirDateTimeComparerFactory().Create());

            this.TPInputContext.ActiveDays.AcceptVisitor(
                activeDaysVisitor);

            this.a = indicesAbstractFactory.CreateaFactory().Create(
                activeDaysVisitor.RedBlackTree);

            // d
            IDaysVisitor<INullableValue<int>, FhirDateTime> daysVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.DaysVisitor<INullableValue<int>, FhirDateTime>(
                indexElementsAbstractFactory.CreatedIndexElementFactory(),
                comparersAbstractFactory.CreateFhirDateTimeComparerFactory().Create());

            this.TPInputContext.Days.AcceptVisitor(
                daysVisitor);

            this.d = indicesAbstractFactory.CreatedFactory().Create(
                daysVisitor.RedBlackTree);

            // k
            this.k = indicesAbstractFactory.CreatekFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.TPInputContext.BlockTypes
                .Select(x => indexElementsAbstractFactory.CreatekIndexElementFactory().Create(x))
                .ToImmutableList());

            // l
            this.l = indicesAbstractFactory.CreatelFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.TPInputContext.LengthOfStayDays
                .Select(x => indexElementsAbstractFactory.CreatelIndexElementFactory().Create(x))
                .ToImmutableList());

            // p
            this.p = indicesAbstractFactory.CreatepFactory().Create(
                comparersAbstractFactory.CreateNullableValueintComparerFactory().Create(),
                this.TPInputContext.PatientGroups
                .Select(x => indexElementsAbstractFactory.CreatepIndexElementFactory().Create(x))
                .ToImmutableList());

            // r
            this.r = indicesAbstractFactory.CreaterFactory().Create(
                comparersAbstractFactory.CreateLocationComparerFactory().Create(),
                this.TPInputContext.OperatingRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreaterIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            // s
            this.s = indicesAbstractFactory.CreatesFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.TPInputContext.SurgeonGroups
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            // w
            this.w = indicesAbstractFactory.CreatewFactory().Create(
                comparersAbstractFactory.CreateOrganizationComparerFactory().Create(),
                this.TPInputContext.Wards
                .Select(x => x.Item1)
                .Select(x => indexElementsAbstractFactory.CreatewIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // ar
            this.ar = crossJoinsAbstractFactory.CreatearFactory().Create(
                this.a.Value.Values
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatearCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // pa
            this.pa = crossJoinsAbstractFactory.CreatepaFactory().Create(
                this.p.Value.Values
                .SelectMany(b => this.a.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatepaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // rk
            this.rk = crossJoinsAbstractFactory.CreaterkFactory().Create(
                this.r.Value.Values
                .SelectMany(b => this.k.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreaterkCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sa
            this.sa = crossJoinsAbstractFactory.CreatesaFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.a.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesaCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // sark
            this.sark = crossJoinsAbstractFactory.CreatesarkFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.a.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesaCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.r.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesarCrossJoinElementFactory().Create(a.sIndexElement, a.aIndexElement, b))
                .SelectMany(b => this.k.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatesarkCrossJoinElementFactory().Create(a.sIndexElement, a.aIndexElement, a.rIndexElement, b))
                .ToImmutableList());

            // sk
            this.sk = crossJoinsAbstractFactory.CreateskFactory().Create(
                this.s.Value.Values
                .SelectMany(b => this.k.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreateskCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // wd
            this.wd = crossJoinsAbstractFactory.CreatewdFactory().Create(
                this.w.Value.Values
                .SelectMany(b => this.d.Value.Values, (a, b) => crossJoinElementsAbstractFactory.CreatewdCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // BEDS
            this.BEDS = parametersAbstractFactory.CreateBEDSFactory().Create(
                this.TPInputContext.NumberBeds);

            // dur(p)
            IPatientGroupSurgeryDurationsVisitor<INullableValue<int>, Duration> patientGroupSurgeryDurationsVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.PatientGroupSurgeryDurationsVisitor<INullableValue<int>, Duration>(
                parameterElementsAbstractFactory.CreatedurParameterElementFactory(),
                this.p);

            this.TPInputContext.PatientGroupSurgeryDurations.AcceptVisitor(
                patientGroupSurgeryDurationsVisitor);

            this.dur = parametersAbstractFactory.CreatedurFactory().Create(
                patientGroupSurgeryDurationsVisitor.RedBlackTree);

            // Length(k)
            IBlockTypeTimeBlockLengthsVisitor<INullableValue<int>, Duration> blockTypeTimeBlockLengthsVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.BlockTypeTimeBlockLengthsVisitor<INullableValue<int>, Duration>(
                parameterElementsAbstractFactory.CreateLengthParameterElementFactory(),
                this.k);

            this.TPInputContext.BlockTypeTimeBlockLengths.AcceptVisitor(
                blockTypeTimeBlockLengthsVisitor);

            this.Length = parametersAbstractFactory.CreateLengthFactory().Create(
                blockTypeTimeBlockLengthsVisitor.RedBlackTree);

            // ORday(a, r)
            IDayOperatingRoomOperatingCapacitiesOuterVisitor<FhirDateTime, RedBlackTree<Location, Duration>> dayOperatingRoomOperatingCapacitiesOuterVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.DayOperatingRoomOperatingCapacitiesOuterVisitor<FhirDateTime, RedBlackTree<Location, Duration>>(
                parameterElementsAbstractFactory.CreateORdayParameterElementFactory(),
                this.a,
                this.r);

            this.TPInputContext.DayOperatingRoomOperatingCapacities.AcceptVisitor(
                dayOperatingRoomOperatingCapacitiesOuterVisitor);

            this.ORday = parametersAbstractFactory.CreateORdayFactory().Create(
                dayOperatingRoomOperatingCapacitiesOuterVisitor.RedBlackTree);

            // P(s)
            ISurgeonGroupSubsetPatientGroupsVisitor<Organization, ImmutableSortedSet<INullableValue<int>>> surgeonGroupSubsetPatientGroupsVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.SurgeonGroupSubsetPatientGroupsVisitor<Organization, ImmutableSortedSet<INullableValue<int>>>(
                parameterElementsAbstractFactory.CreatePsParameterElementFactory(),
                this.p,
                this.s);

            this.TPInputContext.SurgeonGroupSubsetPatientGroups.AcceptVisitor(
                surgeonGroupSubsetPatientGroupsVisitor);

            this.Ps = parametersAbstractFactory.CreatePsFactory().Create(
                surgeonGroupSubsetPatientGroupsVisitor.RedBlackTree);

            // P(w)
            IWardSubsetPatientGroupsVisitor<Organization, ImmutableSortedSet<INullableValue<int>>> wardSubsetPatientGroupsVisitor = new Ma2013.A.E.O.Visitors.Contexts.Common.WardSubsetPatientGroupsVisitor<Organization, ImmutableSortedSet<INullableValue<int>>>(
                parameterElementsAbstractFactory.CreatePwParameterElementFactory(),
                this.p,
                this.w);

            this.TPInputContext.WardSubsetPatientGroups.AcceptVisitor(
                wardSubsetPatientGroupsVisitor);

            this.Pw = parametersAbstractFactory.CreatePwFactory().Create(
                wardSubsetPatientGroupsVisitor.RedBlackTree);

            // prob(p, l)
            IPatientGroupDayLengthOfStayProbabilitiesOuterVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> patientGroupDayLengthOfStayProbabilitiesOuterVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.PatientGroupDayLengthOfStayProbabilitiesOuterVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                parameterElementsAbstractFactory.CreateprobParameterElementFactory(),
                this.l,
                this.p);

            this.TPInputContext.PatientGroupDayLengthOfStayProbabilities.AcceptVisitor(
                patientGroupDayLengthOfStayProbabilitiesOuterVisitor);

            this.prob = parametersAbstractFactory.CreateprobFactory().Create(
                patientGroupDayLengthOfStayProbabilitiesOuterVisitor.RedBlackTree);

            // THR(p)
            IPatientGroupThroughputsVisitor<INullableValue<int>, INullableValue<int>> patientGroupThroughputsVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.PatientGroupThroughputsVisitor<INullableValue<int>, INullableValue<int>>(
                parameterElementsAbstractFactory.CreateTHRParameterElementFactory(),
                this.p);

            this.TPInputContext.PatientGroupThroughputs.AcceptVisitor(
                patientGroupThroughputsVisitor);

            this.THR = parametersAbstractFactory.CreateTHRFactory().Create(
                patientGroupThroughputsVisitor.RedBlackTree);

            // W
            this.W = parametersAbstractFactory.CreateWFactory().Create(
                this.TPInputContext.Wards
                .Select(x => parameterElementsAbstractFactory.CreateWParameterElementFactory().Create(
                    this.w.GetElementAt(x.Item1),
                    x.Item2.Select(i => this.s.GetElementAt(i)).ToImmutableList()))
                .ToImmutableList());

            // α(w)
            IWardαVisitor<Organization, INullableValue<decimal>> wardαVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.WardαVisitor<Organization, INullableValue<decimal>>(
                parameterElementsAbstractFactory.CreateαParameterElementFactory(),
                this.w);

            this.TPInputContext.Wardα.AcceptVisitor(
                wardαVisitor);

            this.α = parametersAbstractFactory.CreateαFactory().Create(
                wardαVisitor.RedBlackTree);

            // β(w)
            IWardβVisitor<Organization, INullableValue<decimal>> wardβVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.WardβVisitor<Organization, INullableValue<decimal>>(
                parameterElementsAbstractFactory.CreateβParameterElementFactory(),
                this.w);

            this.TPInputContext.Wardβ.AcceptVisitor(
                wardβVisitor);

            this.β = parametersAbstractFactory.CreateβFactory().Create(
                wardβVisitor.RedBlackTree);

            // γ(w)
            IWardγVisitor<Organization, INullableValue<decimal>> wardγVisitor = new Ma2013.A.E.O.Visitors.Contexts.TP.WardγVisitor<Organization, INullableValue<decimal>>(
                parameterElementsAbstractFactory.CreateγParameterElementFactory(),
                this.w);

            this.TPInputContext.Wardγ.AcceptVisitor(
                wardγVisitor);

            this.γ = parametersAbstractFactory.CreateγFactory().Create(
                wardγVisitor.RedBlackTree);

            // Variables

            // x(p, a)
            this.x = variablesAbstractFactory.CreateTPxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.p.Value.Values, 
                    indexSet2: this.a.Value.Values,
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => int.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Integer));

            // y(w)
            this.y = variablesAbstractFactory.CreateTPyFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => int.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Integer)); 

            // z(s, a, r, k)
            this.z = variablesAbstractFactory.CreateTPzFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.s.Value.Values, 
                    indexSet2: this.a.Value.Values, 
                    indexSet3: this.r.Value.Values, 
                    indexSet4: this.k.Value.Values, 
                    lowerBoundGenerator: (a, b, c, d) => 0,
                    upperBoundGenerator: (a, b, c, d) => 1, 
                    variableTypeGenerator: (a, b, c, d) => VariableType.Binary)); 

            // δMinus(w, d)
            this.δMinus = variablesAbstractFactory.CreateδMinusFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    indexSet2: this.d.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // δPlus(w)
            this.δPlus_w = variablesAbstractFactory.CreateδPluswFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    lowerBoundGenerator: (a) => 0, 
                    upperBoundGenerator: (a) => double.MaxValue, 
                    variableTypeGenerator: (a) => VariableType.Continuous));

            // δPlus(w, d)
            this.δPlus_wd = variablesAbstractFactory.CreateδPluswdFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    indexSet2: this.d.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0, 
                    upperBoundGenerator: (a, b) => double.MaxValue, 
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // μ(w, d)
            this.μ = variablesAbstractFactory.CreateμFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    indexSet2: this.d.Value.Values, 
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => double.MaxValue,
                    variableTypeGenerator: (a, b) => VariableType.Continuous));

            // Variance(w)
            this.Variance_w = variablesAbstractFactory.CreateVariancewFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    lowerBoundGenerator: (a) => 0,
                    upperBoundGenerator: (a) => double.MaxValue,
                    variableTypeGenerator: (a) => VariableType.Continuous));

            // Variance(w, d)
            this.Variance_wd = variablesAbstractFactory.CreateVariancewdFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.w.Value.Values, 
                    indexSet2: this.d.Value.Values, 
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
                this.p.Value.Values
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