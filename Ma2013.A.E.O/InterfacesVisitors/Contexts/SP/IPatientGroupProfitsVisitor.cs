namespace Ma2013.A.E.O.InterfacesVisitors.Contexts.SP
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;

    public interface IPatientGroupProfitsVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : Money
    {
        RedBlackTree<IpIndexElement, IrParameterElement> RedBlackTree { get; }
    }
}