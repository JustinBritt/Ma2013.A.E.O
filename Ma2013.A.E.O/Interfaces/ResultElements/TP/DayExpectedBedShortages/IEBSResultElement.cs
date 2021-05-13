namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IEBSResultElement
    {
        IdIndexElement dIndexElement { get; }

        decimal Value { get; }
    }
}