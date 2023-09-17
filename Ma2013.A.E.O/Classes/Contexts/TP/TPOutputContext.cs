namespace Ma2013.A.E.O.Classes.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.TP;
    using Ma2013.A.E.O.Interfaces.Models.TP;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;

    internal sealed class TPOutputContext : ITPOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ITPModel TPModel,
            Solution solution)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // x(p, a)
            Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments.ITPx x = TPModel.x.GetElementsAt(
                resultElementsAbstractFactory.CreateTPxResultElementFactory(),
                resultsAbstractFactory.CreateTPxFactory(),
                TPModel.pa);

            this.PatientGroupActiveDayNumberPatientAssignments = x
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // y(w)
            this.WardNumberBedAssignments = TPModel.y.GetElementsAt(
                resultElementsAbstractFactory.CreateTPyResultElementFactory(),
                resultsAbstractFactory.CreateTPyFactory(),
                TPModel.w)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // z(s, a, r, k)
            Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments.ITPz z = TPModel.z.GetElementsAt(
                resultElementsAbstractFactory.CreateTPzResultElementFactory(),
                resultsAbstractFactory.CreateTPzFactory(),
                TPModel.sark);

            this.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments = z
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // δMinus(w, d)
            this.WardDayBedAvailabilityMinusDeviations = TPModel.δMinus.GetElementsAt(
                resultElementsAbstractFactory.CreateδMinusResultElementFactory(),
                resultsAbstractFactory.CreateδMinusFactory(),
                TPModel.wd)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // δPlus(w)
            this.WardSpareBeds = TPModel.δPlus_w.GetElementsAt(
                resultElementsAbstractFactory.CreateδPluswResultElementFactory(),
                resultsAbstractFactory.CreateδPluswFactory(),
                TPModel.w)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // δPlus(w, d)
            this.WardDayBedAvailabilityPlusDeviations = TPModel.δPlus_wd.GetElementsAt(
                resultElementsAbstractFactory.CreateδPluswdResultElementFactory(),
                resultsAbstractFactory.CreateδPluswdFactory(),
                TPModel.wd)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // μ(w, d)
            Interfaces.Results.TP.WardDayBedRequirementMeans.Iμ μ = TPModel.μ.GetElementsAt(
                resultElementsAbstractFactory.CreateμResultElementFactory(),
                resultsAbstractFactory.CreateμFactory(),
                TPModel.wd);

            this.WardDayBedRequirementMeans = μ
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Variance(w)
            this.WardBedOccupancyVariances = TPModel.Variance_w.GetElementsAt(
                resultElementsAbstractFactory.CreateVariancewResultElementFactory(),
                resultsAbstractFactory.CreateVariancewFactory(),
                TPModel.w)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Variance(w, d)
            Interfaces.Results.TP.WardDayBedRequirementVariances.IVariance Variance_wd = TPModel.Variance_wd.GetElementsAt(
                resultElementsAbstractFactory.CreateVariancewdResultElementFactory(),
                resultsAbstractFactory.CreateVariancewdFactory(),
                TPModel.wd);

            this.WardDayBedRequirementVariances = Variance_wd
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // DayBedRequirementMeans(d)
            this.DayBedRequirementMeans = calculationsAbstractFactory.CreateDayBedRequirementMeansCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateDayBedRequirementMeansResultElementFactory(),
                resultsAbstractFactory.CreateDayBedRequirementMeansFactory(),
                calculationsAbstractFactory.CreateDayBedRequirementMeansResultElementCalculationFactory().Create(),
                TPModel.d,
                μ)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // DayBedRequirementVariances(d)
            this.DayBedRequirementVariances = calculationsAbstractFactory.CreateDayBedRequirementVariancesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateDayBedRequirementVariancesResultElementFactory(),
                resultsAbstractFactory.CreateDayBedRequirementVariancesFactory(),
                calculationsAbstractFactory.CreateDayBedRequirementVariancesResultElementCalculationFactory().Create(),
                TPModel.d,
                Variance_wd)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // EBS(d)
            Interfaces.Results.TP.DayExpectedBedShortages.IEBS EBS = calculationsAbstractFactory.CreateEBSCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateEBSResultElementFactory(),
                resultsAbstractFactory.CreateEBSFactory(),
                calculationsAbstractFactory.CreateEBSResultElementCalculationFactory().Create(),
                TPModel.d,
                TPModel.w,
                TPModel.BEDS,
                μ,
                Variance_wd);

            this.DayExpectedBedShortages = EBS
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberPatients
            this.NumberPatients = calculationsAbstractFactory.CreateNumberPatientsCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateNumberPatientsFactory(),
                TPModel.pa,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonGroupNumberAssignedOperatingRooms(s)
            this.SurgeonGroupNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateSurgeonGroupNumberAssignedOperatingRoomsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateSurgeonGroupNumberAssignedOperatingRoomsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonGroupNumberAssignedOperatingRoomsFactory(),
                calculationsAbstractFactory.CreateSurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                TPModel.s,
                z)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonGroupNumberAssignedActiveDays(s)
            this.SurgeonGroupNumberAssignedActiveDays = calculationsAbstractFactory.CreateSurgeonGroupNumberAssignedActiveDaysCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateSurgeonGroupNumberAssignedActiveDaysResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonGroupNumberAssignedActiveDaysFactory(),
                calculationsAbstractFactory.CreateSurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory().Create(),
                TPModel.s,
                z)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonGroupNumberPatients(s)
            this.SurgeonGroupNumberPatients = calculationsAbstractFactory.CreateSurgeonGroupNumberPatientsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateSurgeonGroupNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonGroupNumberPatientsFactory(),
                calculationsAbstractFactory.CreateSurgeonGroupNumberPatientsResultElementCalculationFactory().Create(),
                TPModel.s,
                TPModel.pa,
                TPModel.Ps,
                x)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // TEBS
            this.TotalExpectedBedShortage = calculationsAbstractFactory.CreateTEBSCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateTEBSFactory(),
                TPModel.d,
                EBS)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // TotalTime
            ITotalTime totalTime = calculationsAbstractFactory.CreateTotalTimeCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateTotalTimeFactory(),
                TPModel.sark,
                TPModel.Length,
                z);

                this.TotalTime = totalTime.GetValueForOutputContext(
                    dependenciesAbstractFactory.CreateNullableValueFactory());

            // UtilizedTime
            IUtilizedTime utilizedTime = calculationsAbstractFactory.CreateUtilizedTimeCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateUtilizedTimeFactory(),
                TPModel.pa,
                TPModel.dur,
                x);

            this.UtilizedTime = utilizedTime.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // UnutilizedTime
            IUnutilizedTime unutilizedTime = calculationsAbstractFactory.CreateUnutilizedTimeCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateUnutilizedTimeFactory(),
                totalTime,
                utilizedTime);

            this.UnutilizedTime = unutilizedTime.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Underutilization
            this.Underutilization = calculationsAbstractFactory.CreateUnderutilizationCalculationFactory().Create()
                .Calculate(
                resultsAbstractFactory.CreateUnderutilizationFactory(),
                totalTime,
                unutilizedTime)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // WardNumberAssignedOperatingRooms(w)
            this.WardNumberAssignedOperatingRooms = calculationsAbstractFactory.CreateWardNumberAssignedOperatingRoomsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateWardNumberAssignedOperatingRoomsResultElementFactory(),
                resultsAbstractFactory.CreateWardNumberAssignedOperatingRoomsFactory(),
                calculationsAbstractFactory.CreateWardNumberAssignedOperatingRoomsResultElementCalculationFactory().Create(),
                TPModel.W,
                z)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // WardGroupNumberAssignedActiveDays(w)
            this.WardNumberAssignedActiveDays = calculationsAbstractFactory.CreateWardNumberAssignedActiveDaysCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateWardNumberAssignedActiveDaysResultElementFactory(),
                resultsAbstractFactory.CreateWardNumberAssignedActiveDaysFactory(),
                calculationsAbstractFactory.CreateWardNumberAssignedActiveDaysResultElementCalculationFactory().Create(),
                TPModel.W,
                z)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedRequirementMeans { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedRequirementVariances { get; }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> DayExpectedBedShortages { get; }

        public INullableValue<decimal> Gap { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<int> NumberPatients { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonGroupNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonGroupNumberAssignedActiveDays { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonGroupNumberPatients { get; }

        public INullableValue<decimal> TotalExpectedBedShortage { get; }

        public INullableValue<decimal> TotalTime { get; }

        public INullableValue<decimal> Underutilization { get; }

        public INullableValue<decimal> UnutilizedTime { get; }

        public INullableValue<decimal> UtilizedTime { get; }

        public RedBlackTree<Organization, INullableValue<int>> WardNumberAssignedOperatingRooms { get; }

        public RedBlackTree<Organization, INullableValue<int>> WardNumberAssignedActiveDays { get; }

        public ImmutableList<Tuple<INullableValue<int>, FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        public RedBlackTree<Organization, INullableValue<int>> WardNumberBedAssignments { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, Location, INullableValue<int>, INullableValue<bool>>> SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityMinusDeviations { get; }

        public ImmutableList<Tuple<Organization, INullableValue<decimal>>> WardSpareBeds { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityPlusDeviations { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementMeans { get; }

        public ImmutableList<Tuple<Organization, INullableValue<decimal>>> WardBedOccupancyVariances { get; }

        public ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementVariances { get; }
    }
}