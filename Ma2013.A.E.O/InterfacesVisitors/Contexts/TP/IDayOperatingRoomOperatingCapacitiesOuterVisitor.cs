namespace Ma2013.A.E.O.InterfacesVisitors.Contexts.TP
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;

    public interface IDayOperatingRoomOperatingCapacitiesOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : FhirDateTime
        where TValue : RedBlackTree<Location, Duration>
    {
        RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>> RedBlackTree { get; }
    }
}