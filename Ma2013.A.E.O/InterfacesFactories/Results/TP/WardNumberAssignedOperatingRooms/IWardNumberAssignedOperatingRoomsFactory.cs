namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedOperatingRooms;

    public interface IWardNumberAssignedOperatingRoomsFactory
    {
        IWardNumberAssignedOperatingRooms Create(
            ImmutableList<IWardNumberAssignedOperatingRoomsResultElement> value);
    }
}