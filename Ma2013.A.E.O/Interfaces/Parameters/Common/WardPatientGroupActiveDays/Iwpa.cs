namespace Ma2013.A.E.O.Interfaces.Parameters.Common.WardPatientGroupActiveDays
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface Iwpa
    {
        RedBlackTree<IwIndexElement, RedBlackTree<IpIndexElement, RedBlackTree<IaIndexElement, IpaCrossJoinElement>>> Value { get; }
    }
}