namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;

    public interface IDayBedRequirementVariancesResultElementFactory
    {
        IDayBedRequirementVariancesResultElement Create(
            IdIndexElement dIndexElement,
            decimal value);
    }
}