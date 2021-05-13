namespace Ma2013.A.E.O.Interfaces.CrossJoinElements.TP
{
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IrkCrossJoinElement
    {
        IrIndexElement rIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}