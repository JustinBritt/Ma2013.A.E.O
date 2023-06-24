namespace Ma2013.A.E.O.Interfaces.Indices.TP
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface Il
    {
        RedBlackTree<INullableValue<int>, IlIndexElement> Value { get; }

        IlIndexElement GetElementAt(
            int value);

        IlIndexElement GetElementAt(
            INullableValue<int> value);

        int GetMaximumLengthOfStay();
    }
}