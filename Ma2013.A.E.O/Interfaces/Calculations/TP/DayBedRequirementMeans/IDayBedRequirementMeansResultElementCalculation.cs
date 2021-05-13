namespace Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementMeans
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;

    public interface IDayBedRequirementMeansResultElementCalculation
    {
        IDayBedRequirementMeansResultElement Calculate(
            IDayBedRequirementMeansResultElementFactory dayBedRequirementMeansResultElementFactory,
            IdIndexElement dIndexElement,
            Iμ μ);
    }
}