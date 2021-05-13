namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;

    public interface IORdayFactory
    {
        IORday Create(
            ImmutableList<IORdayParameterElement> value);
    }
}