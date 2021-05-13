namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.BestBound;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.Gap;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.OverallWallTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.Underutilization;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberBedAssignments;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        IDayBedRequirementMeansFactory CreateDayBedRequirementMeansFactory();

        IDayBedRequirementVariancesFactory CreateDayBedRequirementVariancesFactory();

        IEBSFactory CreateEBSFactory();

        IGapFactory CreateGapFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        INumberPatientsFactory CreateNumberPatientsFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        ISPxFactory CreateSPxFactory();

        ISPyFactory CreateSPyFactory();

        ISPzFactory CreateSPzFactory();

        ISurgeonGroupNumberAssignedOperatingRoomsFactory CreateSurgeonGroupNumberAssignedOperatingRoomsFactory();

        ISurgeonGroupNumberAssignedActiveDaysFactory CreateSurgeonGroupNumberAssignedActiveDaysFactory();

        ISurgeonGroupNumberPatientsFactory CreateSurgeonGroupNumberPatientsFactory();

        ITEBSFactory CreateTEBSFactory();

        ITotalFinancialContributionFactory CreateTotalFinancialContributionFactory();

        ITotalTimeFactory CreateTotalTimeFactory();

        ITPxFactory CreateTPxFactory();

        ITPyFactory CreateTPyFactory();

        ITPzFactory CreateTPzFactory();

        IUnderutilizationFactory CreateUnderutilizationFactory();

        IUnutilizedTimeFactory CreateUnutilizedTimeFactory();

        IUtilizedTimeFactory CreateUtilizedTimeFactory();

        Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances.IVarianceFactory CreateVariancewFactory();

        Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementVariances.IVarianceFactory CreateVariancewdFactory();

        IWardNumberAssignedOperatingRoomsFactory CreateWardNumberAssignedOperatingRoomsFactory();

        IWardNumberAssignedActiveDaysFactory CreateWardNumberAssignedActiveDaysFactory();

        IδMinusFactory CreateδMinusFactory();

        Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds.IδPlusFactory CreateδPluswFactory();

        Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations.IδPlusFactory CreateδPluswdFactory();

        IμFactory CreateμFactory();
    }
}