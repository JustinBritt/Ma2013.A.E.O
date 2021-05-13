namespace Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.TP
{
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IsarkCrossJoinElementFactory
    {
        IsarkCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement);
    }
}