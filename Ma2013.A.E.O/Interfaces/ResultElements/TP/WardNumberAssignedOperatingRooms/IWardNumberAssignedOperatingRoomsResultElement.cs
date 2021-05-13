namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IWardNumberAssignedOperatingRoomsResultElement
    {
        IwIndexElement wIndexElement { get; }

        int Value { get; }
    }
}