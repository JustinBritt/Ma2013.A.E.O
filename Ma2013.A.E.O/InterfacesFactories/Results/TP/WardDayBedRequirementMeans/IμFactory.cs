namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementMeans
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;

    public interface IμFactory
    {
        Iμ Create(
            ImmutableList<IμResultElement> value);
    }
}