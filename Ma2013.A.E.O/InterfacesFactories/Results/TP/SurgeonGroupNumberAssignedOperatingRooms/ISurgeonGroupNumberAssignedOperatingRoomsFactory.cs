namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;

    public interface ISurgeonGroupNumberAssignedOperatingRoomsFactory
    {
        ISurgeonGroupNumberAssignedOperatingRooms Create(
            ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> value);
    }
}