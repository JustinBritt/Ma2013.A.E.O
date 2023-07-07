namespace Ma2013.A.E.O.InterfacesVisitors.Contexts.Common
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using System.Collections.Immutable;

    public interface ISurgeonGroupSubsetPatientGroupsVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : IImmutableSet<INullableValue<int>>
    {
        RedBlackTree<IsIndexElement, IPParameterElement> RedBlackTree { get; }
    }
}