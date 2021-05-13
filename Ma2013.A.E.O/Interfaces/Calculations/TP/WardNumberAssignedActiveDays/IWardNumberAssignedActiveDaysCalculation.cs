namespace Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedActiveDays;

    public interface IWardNumberAssignedActiveDaysCalculation
    {
        IWardNumberAssignedActiveDays Calculate(
               IWardNumberAssignedActiveDaysResultElementFactory wardNumberAssignedActiveDaysResultElementFactory,
               IWardNumberAssignedActiveDaysFactory wardNumberAssignedActiveDaysFactory,
               IWardNumberAssignedActiveDaysResultElementCalculation wardNumberAssignedActiveDaysResultElementCalculation,
               IW W,
               ITPz z);
    }
}