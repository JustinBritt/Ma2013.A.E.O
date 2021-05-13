namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IδMinusResultElement
    {
        IwIndexElement wIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        decimal Value { get; }
    }
}