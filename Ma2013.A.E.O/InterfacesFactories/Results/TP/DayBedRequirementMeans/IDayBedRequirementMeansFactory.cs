namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementMeans
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementMeans;

    public interface IDayBedRequirementMeansFactory
    {
        IDayBedRequirementMeans Create(
            ImmutableList<IDayBedRequirementMeansResultElement> value);
    }
}