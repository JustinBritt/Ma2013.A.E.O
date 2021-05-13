namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardBedOccupancyVariances;

    public interface IVarianceFactory
    {
        IVariance Create(
            ImmutableList<IVarianceResultElement> value);
    }
}