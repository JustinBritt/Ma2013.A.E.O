namespace Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementVariances
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementVariances;

    public interface IDayBedRequirementVariancesCalculation
    {
        IDayBedRequirementVariances Calculate(
            IDayBedRequirementVariancesResultElementFactory dayBedRequirementVariancesResultElementFactory,
            IDayBedRequirementVariancesFactory dayBedRequirementVariancesFactory,
            IDayBedRequirementVariancesResultElementCalculation dayBedRequirementVariancesResultElementCalculation,
            Id d,
            IVariance Variance);
    }
}