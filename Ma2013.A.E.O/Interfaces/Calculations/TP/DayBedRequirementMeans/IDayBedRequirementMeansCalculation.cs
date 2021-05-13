namespace Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementMeans
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementMeans;

    public interface IDayBedRequirementMeansCalculation
    {
        IDayBedRequirementMeans Calculate(
            IDayBedRequirementMeansResultElementFactory dayBedRequirementMeansResultElementFactory,
            IDayBedRequirementMeansFactory dayBedRequirementMeansFactory,
            IDayBedRequirementMeansResultElementCalculation dayBedRequirementMeansResultElementCalculation,
            Id d,
            Iμ μ);
    }
}