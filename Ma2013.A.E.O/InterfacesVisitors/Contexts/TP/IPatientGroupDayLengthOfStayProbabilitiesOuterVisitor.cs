namespace Ma2013.A.E.O.InterfacesVisitors.Contexts.TP
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;

    public interface IPatientGroupDayLengthOfStayProbabilitiesOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        RedBlackTree<IpIndexElement, RedBlackTree<IlIndexElement, IprobParameterElement>> RedBlackTree { get; }
    }
}