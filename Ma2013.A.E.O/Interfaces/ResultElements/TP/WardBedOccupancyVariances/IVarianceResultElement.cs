namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IVarianceResultElement
    {
        IwIndexElement wIndexElement { get; }

        decimal Value { get; }
    }
}