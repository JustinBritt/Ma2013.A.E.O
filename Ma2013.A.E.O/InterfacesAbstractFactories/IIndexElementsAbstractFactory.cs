namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.TP;

    public interface IIndexElementsAbstractFactory
    {
        IaIndexElementFactory CreateaIndexElementFactory();

        IdIndexElementFactory CreatedIndexElementFactory();

        IkIndexElementFactory CreatekIndexElementFactory();

        IlIndexElementFactory CreatelIndexElementFactory();

        IpIndexElementFactory CreatepIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IsIndexElementFactory CreatesIndexElementFactory();

        IwIndexElementFactory CreatewIndexElementFactory();
    }
}