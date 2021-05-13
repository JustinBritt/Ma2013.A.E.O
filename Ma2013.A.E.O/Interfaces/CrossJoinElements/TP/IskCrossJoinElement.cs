namespace Ma2013.A.E.O.Interfaces.CrossJoinElements.TP
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IskCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IkIndexElement kIndexElement { get; }
    }
}