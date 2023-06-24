namespace Ma2013.A.E.O.InterfacesVisitors.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IPatientGroupDaySubsetActiveDaysVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Tuple<INullableValue<int>, FhirDateTime>
        where TValue : IImmutableSet<FhirDateTime>
    {
        RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>> RedBlackTree { get; }
    }
}