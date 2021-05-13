namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardSpareBeds
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;

    public interface IδPlusResultElementFactory
    {
        IδPlusResultElement Create(
            IwIndexElement wIndexElement,
            decimal value);
    }
}