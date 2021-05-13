namespace Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;

    public interface IWardNumberAssignedActiveDaysResultElementCalculation
    {
        IWardNumberAssignedActiveDaysResultElement Calculate(
            IWardNumberAssignedActiveDaysResultElementFactory wardNumberAssignedActiveDaysResultElementFactory,
            IWParameterElement WParameterElement,
            ITPz z);
    }
}