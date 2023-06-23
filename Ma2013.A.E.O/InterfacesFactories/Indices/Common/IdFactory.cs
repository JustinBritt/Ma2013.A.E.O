namespace Ma2013.A.E.O.InterfacesFactories.Indices.Common
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IdFactory
    {
        Ma2013.A.E.O.Interfaces.Indices.Common.Id Create(
            RedBlackTree<FhirDateTime, IdIndexElement> value);
    }
}