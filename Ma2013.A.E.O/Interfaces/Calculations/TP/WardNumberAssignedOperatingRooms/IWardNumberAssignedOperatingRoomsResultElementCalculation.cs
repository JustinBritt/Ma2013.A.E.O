namespace Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgicalSpecialties;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;

    public interface IWardNumberAssignedOperatingRoomsResultElementCalculation
    {
        IWardNumberAssignedOperatingRoomsResultElement Calculate(
            IWardNumberAssignedOperatingRoomsResultElementFactory wardNumberAssignedOperatingRoomsResultElementFactory,
            IWParameterElement WParameterElement,
            ITPz z);
    }
}