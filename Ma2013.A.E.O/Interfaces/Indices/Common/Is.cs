namespace Ma2013.A.E.O.Interfaces.Indices.Common
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface Is
    {
        RedBlackTree<Organization, IsIndexElement> Value { get; }

        IsIndexElement GetElementAt(
            Organization value);
    }
}