namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;

    public interface IAFactory
    {
        IA Create(
            RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>> value);
    }
}