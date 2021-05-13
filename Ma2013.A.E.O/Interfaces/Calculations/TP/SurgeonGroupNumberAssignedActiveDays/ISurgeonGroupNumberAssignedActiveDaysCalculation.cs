namespace Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedActiveDays;

    public interface ISurgeonGroupNumberAssignedActiveDaysCalculation
    {
        ISurgeonGroupNumberAssignedActiveDays Calculate(
            ISurgeonGroupNumberAssignedActiveDaysResultElementFactory surgeonGroupNumberAssignedActiveDaysResultElementFactory,
            ISurgeonGroupNumberAssignedActiveDaysFactory surgeonGroupNumberAssignedActiveDaysFactory,
            ISurgeonGroupNumberAssignedActiveDaysResultElementCalculation surgeonGroupNumberAssignedActiveDaysResultElementCalculation,
            Is s,
            ITPz z);
    }
}