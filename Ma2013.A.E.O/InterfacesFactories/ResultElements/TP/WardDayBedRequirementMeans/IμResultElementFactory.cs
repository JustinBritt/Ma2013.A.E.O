namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementMeans
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementMeans;

    public interface IμResultElementFactory
    {
        IμResultElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value);
    }
}