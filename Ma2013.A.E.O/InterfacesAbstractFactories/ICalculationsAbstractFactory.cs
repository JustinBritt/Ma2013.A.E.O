namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Calculations.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.Underutilization;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedActiveDays;

    public interface ICalculationsAbstractFactory
    {
        IDayBedRequirementMeansCalculationFactory CreateDayBedRequirementMeansCalculationFactory();

        IDayBedRequirementMeansResultElementCalculationFactory CreateDayBedRequirementMeansResultElementCalculationFactory();

        IDayBedRequirementVariancesCalculationFactory CreateDayBedRequirementVariancesCalculationFactory();

        IDayBedRequirementVariancesResultElementCalculationFactory CreateDayBedRequirementVariancesResultElementCalculationFactory();

        IEBSCalculationFactory CreateEBSCalculationFactory();

        IEBSResultElementCalculationFactory CreateEBSResultElementCalculationFactory();

        INumberPatientsCalculationFactory CreateNumberPatientsCalculationFactory();

        ISurgeonGroupNumberAssignedOperatingRoomsCalculationFactory CreateSurgeonGroupNumberAssignedOperatingRoomsCalculationFactory();

        ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory CreateSurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory();

        ISurgeonGroupNumberAssignedActiveDaysCalculationFactory CreateSurgeonGroupNumberAssignedActiveDaysCalculationFactory();

        ISurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory CreateSurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory();

        ISurgeonGroupNumberPatientsCalculationFactory CreateSurgeonGroupNumberPatientsCalculationFactory();

        ISurgeonGroupNumberPatientsResultElementCalculationFactory CreateSurgeonGroupNumberPatientsResultElementCalculationFactory();

        ITEBSCalculationFactory CreateTEBSCalculationFactory();

        ITotalFinancialContributionCalculationFactory CreateTotalFinancialContributionCalculationFactory();

        ITotalTimeCalculationFactory CreateTotalTimeCalculationFactory();

        IUnderutilizationCalculationFactory CreateUnderutilizationCalculationFactory();

        IUnutilizedTimeCalculationFactory CreateUnutilizedTimeCalculationFactory();

        IUtilizedTimeCalculationFactory CreateUtilizedTimeCalculationFactory();

        IWardNumberAssignedOperatingRoomsCalculationFactory CreateWardNumberAssignedOperatingRoomsCalculationFactory();

        IWardNumberAssignedOperatingRoomsResultElementCalculationFactory CreateWardNumberAssignedOperatingRoomsResultElementCalculationFactory();

        IWardNumberAssignedActiveDaysCalculationFactory CreateWardNumberAssignedActiveDaysCalculationFactory();

        IWardNumberAssignedActiveDaysResultElementCalculationFactory CreateWardNumberAssignedActiveDaysResultElementCalculationFactory();
    }
}