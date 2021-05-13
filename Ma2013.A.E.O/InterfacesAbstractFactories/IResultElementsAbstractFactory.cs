namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberBedAssignments;

    public interface IResultElementsAbstractFactory
    {
        IDayBedRequirementMeansResultElementFactory CreateDayBedRequirementMeansResultElementFactory();

        IDayBedRequirementVariancesResultElementFactory CreateDayBedRequirementVariancesResultElementFactory();

        IEBSResultElementFactory CreateEBSResultElementFactory();

        ISPxResultElementFactory CreateSPxResultElementFactory();

        ISPyResultElementFactory CreateSPyResultElementFactory();

        ISPzResultElementFactory CreateSPzResultElementFactory();

        ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory CreateSurgeonGroupNumberAssignedOperatingRoomsResultElementFactory();

        ISurgeonGroupNumberAssignedActiveDaysResultElementFactory CreateSurgeonGroupNumberAssignedActiveDaysResultElementFactory();

        ISurgeonGroupNumberPatientsResultElementFactory CreateSurgeonGroupNumberPatientsResultElementFactory();

        ITPxResultElementFactory CreateTPxResultElementFactory();

        ITPyResultElementFactory CreateTPyResultElementFactory();

        ITPzResultElementFactory CreateTPzResultElementFactory();

        Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances.IVarianceResultElementFactory CreateVariancewResultElementFactory();

        Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances.IVarianceResultElementFactory CreateVariancewdResultElementFactory();

        IWardNumberAssignedOperatingRoomsResultElementFactory CreateWardNumberAssignedOperatingRoomsResultElementFactory();

        IWardNumberAssignedActiveDaysResultElementFactory CreateWardNumberAssignedActiveDaysResultElementFactory();

        IδMinusResultElementFactory CreateδMinusResultElementFactory();

        Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds.IδPlusResultElementFactory CreateδPluswResultElementFactory();

        Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations.IδPlusResultElementFactory CreateδPluswdResultElementFactory();

        IμResultElementFactory CreateμResultElementFactory();
    }
}