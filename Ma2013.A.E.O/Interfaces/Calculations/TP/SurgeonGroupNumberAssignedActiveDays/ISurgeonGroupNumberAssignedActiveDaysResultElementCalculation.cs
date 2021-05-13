namespace Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;

    public interface ISurgeonGroupNumberAssignedActiveDaysResultElementCalculation
    {
        ISurgeonGroupNumberAssignedActiveDaysResultElement Calculate(
            ISurgeonGroupNumberAssignedActiveDaysResultElementFactory surgeonGroupNumberAssignedActiveDaysResultElementFactory,
            IsIndexElement sIndexElement,
            ITPz z);
    }
}