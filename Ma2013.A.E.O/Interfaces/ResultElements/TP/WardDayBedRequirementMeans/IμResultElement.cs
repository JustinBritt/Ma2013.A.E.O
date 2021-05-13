namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementMeans
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IμResultElement
    {
        IwIndexElement wIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        decimal Value { get; }
    }
}