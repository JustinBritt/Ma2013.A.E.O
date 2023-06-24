namespace Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IA
    {
        RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>> Value { get; }

        bool IsThereElementAt(
            IpaCrossJoinElement paCrossJoinElement,
            IdIndexElement dIndexElement);
    }
}