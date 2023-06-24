namespace Ma2013.A.E.O.Interfaces.Indices.TP
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface Ir
    {
        RedBlackTree<Location, IrIndexElement> Value { get; }

        IrIndexElement GetElementAt(
            Location value);
    }
}