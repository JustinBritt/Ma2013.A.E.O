namespace Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.TP
{
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IrkCrossJoinElementFactory
    {
        IrkCrossJoinElement Create(
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement);
    }
}