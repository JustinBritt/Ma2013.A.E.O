namespace Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;

    public interface ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation
    {
        ISurgeonGroupNumberAssignedOperatingRoomsResultElement Calculate(
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory surgeonGroupNumberAssignedOperatingRoomsResultElementFactory,
            IsIndexElement sIndexElement,
            ITPz z);
    }
}