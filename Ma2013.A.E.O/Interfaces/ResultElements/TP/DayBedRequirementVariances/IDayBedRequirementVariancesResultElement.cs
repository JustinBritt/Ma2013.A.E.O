namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IDayBedRequirementVariancesResultElement
    {
        IdIndexElement dIndexElement { get; }

        decimal Value { get; }
    }
}