namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;

    public interface IDayBedRequirementMeansResultElementFactory
    {
        IDayBedRequirementMeansResultElement Create(
            IdIndexElement dIndexElement,
            decimal value);
    }
}