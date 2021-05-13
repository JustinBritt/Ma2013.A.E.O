namespace Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;

    public interface IDayBedRequirementVariancesResultElementCalculation
    {
        IDayBedRequirementVariancesResultElement Calculate(
            IDayBedRequirementVariancesResultElementFactory dayBedRequirementVariancesResultElementFactory,
            IdIndexElement dIndexElement,
            IVariance Variance);
    }
}