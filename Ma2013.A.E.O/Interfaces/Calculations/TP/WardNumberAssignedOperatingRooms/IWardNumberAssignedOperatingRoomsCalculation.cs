namespace Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedOperatingRooms;

    public interface IWardNumberAssignedOperatingRoomsCalculation
    {
        IWardNumberAssignedOperatingRooms Calculate(
            IWardNumberAssignedOperatingRoomsResultElementFactory wardNumberAssignedOperatingRoomsResultElementFactory,
            IWardNumberAssignedOperatingRoomsFactory wardNumberAssignedOperatingRoomsFactory,
            IWardNumberAssignedOperatingRoomsResultElementCalculation wardNumberAssignedOperatingRoomsResultElementCalculation,
            IW W,
            ITPz z);
    }
}