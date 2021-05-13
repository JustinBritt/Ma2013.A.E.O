namespace Ma2013.A.E.O.Interfaces.CrossJoinElements.TP
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IarCrossJoinElement
    {
        IaIndexElement aIndexElement { get; }

        IrIndexElement rIndexElement { get; }
    }
}