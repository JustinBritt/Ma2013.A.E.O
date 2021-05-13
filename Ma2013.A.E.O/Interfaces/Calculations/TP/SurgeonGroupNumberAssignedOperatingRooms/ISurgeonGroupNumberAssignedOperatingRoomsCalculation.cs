namespace Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;

    public interface ISurgeonGroupNumberAssignedOperatingRoomsCalculation
    {
        ISurgeonGroupNumberAssignedOperatingRooms Calculate(
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory surgeonGroupNumberAssignedOperatingRoomsResultElementFactory,
            ISurgeonGroupNumberAssignedOperatingRoomsFactory surgeonGroupNumberAssignedOperatingRoomsFactory,
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation surgeonGroupNumberAssignedOperatingRoomsResultElementCalculation,
            Is s,
            ITPz z);
    }
}