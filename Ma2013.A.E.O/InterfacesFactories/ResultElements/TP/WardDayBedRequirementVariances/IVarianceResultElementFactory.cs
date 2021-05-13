namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances;

    public interface IVarianceResultElementFactory
    {
        IVarianceResultElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value);
    }
}