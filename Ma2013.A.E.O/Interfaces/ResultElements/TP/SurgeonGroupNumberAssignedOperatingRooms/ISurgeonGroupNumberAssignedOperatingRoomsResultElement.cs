namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ISurgeonGroupNumberAssignedOperatingRoomsResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}