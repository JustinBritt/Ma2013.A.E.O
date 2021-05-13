namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedAvailabilityDeviations;

    public interface IδMinusFactory
    {
        IδMinus Create(
            ImmutableList<IδMinusResultElement> value);
    }
}