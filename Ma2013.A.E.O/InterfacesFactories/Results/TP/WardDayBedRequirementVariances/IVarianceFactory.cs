namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementVariances
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;

    public interface IVarianceFactory
    {
        IVariance Create(
            ImmutableList<IVarianceResultElement> value);
    }
}