namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementVariances
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementVariances;

    public interface IDayBedRequirementVariancesFactory
    {
        IDayBedRequirementVariances Create(
            ImmutableList<IDayBedRequirementVariancesResultElement> value);
    }
}