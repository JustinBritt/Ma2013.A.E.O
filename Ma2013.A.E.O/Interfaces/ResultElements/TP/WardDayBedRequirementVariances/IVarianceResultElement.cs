namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IVarianceResultElement
    {
        IwIndexElement wIndexElement { get; }

        IdIndexElement dIndexElement { get; }

        decimal Value { get; }
    }
}