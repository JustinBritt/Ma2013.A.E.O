namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;

    public interface ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory
    {
        ISurgeonGroupNumberAssignedOperatingRoomsResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}