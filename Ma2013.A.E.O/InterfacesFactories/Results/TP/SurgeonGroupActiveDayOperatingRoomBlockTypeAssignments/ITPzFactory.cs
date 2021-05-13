namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    public interface ITPzFactory
    {
        ITPz Create(
            ImmutableList<ITPzResultElement> value);
    }
}