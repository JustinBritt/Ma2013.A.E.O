namespace Ma2013.A.E.O.Interfaces.Indices.TP
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface Ik
    {
        RedBlackTree<INullableValue<int>, IkIndexElement> Value { get; }

        IkIndexElement GetElementAt(
            INullableValue<int> value);
    }
}