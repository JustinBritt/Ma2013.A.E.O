namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IDayBedRequirementMeansResultElement
    {
        IdIndexElement dIndexElement { get; }

        decimal Value { get; }
    }
}