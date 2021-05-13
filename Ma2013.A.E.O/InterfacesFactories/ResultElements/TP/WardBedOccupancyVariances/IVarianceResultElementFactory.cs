namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances;

    public interface IVarianceResultElementFactory
    {
        IVarianceResultElement Create(
            IwIndexElement wIndexElement,
            decimal value);
    }
}