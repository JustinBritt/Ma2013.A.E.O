namespace Ma2013.A.E.O.Interfaces.CrossJoinElements.TP
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IsarkCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IaIndexElement aIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}