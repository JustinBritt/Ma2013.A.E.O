namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;

    public interface IWardNumberAssignedOperatingRoomsResultElementFactory
    {
        IWardNumberAssignedOperatingRoomsResultElement Create(
            IwIndexElement wIndexElement,
            int value);
    }
}