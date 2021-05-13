namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardSpareBeds;

    public interface IVariablesAbstractFactory
    {
        ISPxFactory CreateSPxFactory();

        ISPyFactory CreateSPyFactory();

        ISPzFactory CreateSPzFactory();

        ITPxFactory CreateTPxFactory();

        ITPyFactory CreateTPyFactory();

        ITPzFactory CreateTPzFactory();

        Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardBedOccupancyVariances.IVarianceFactory CreateVariancewFactory();

        Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementVariances.IVarianceFactory CreateVariancewdFactory();

        IδMinusFactory CreateδMinusFactory();

        Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardSpareBeds.IδPlusFactory CreateδPluswFactory();

        Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations.IδPlusFactory CreateδPluswdFactory();

        IμFactory CreateμFactory();
    }
}