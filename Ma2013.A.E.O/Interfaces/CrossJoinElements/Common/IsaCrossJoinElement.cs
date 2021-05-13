namespace Ma2013.A.E.O.Interfaces.CrossJoinElements.Common
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IsaCrossJoinElement
    {
        IsIndexElement sIndexElement { get; }

        IaIndexElement aIndexElement { get; }
    }
}