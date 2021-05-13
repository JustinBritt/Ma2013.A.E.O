namespace Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;

    public interface IORday
    {
        ImmutableList<IORdayParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement);
    }
}