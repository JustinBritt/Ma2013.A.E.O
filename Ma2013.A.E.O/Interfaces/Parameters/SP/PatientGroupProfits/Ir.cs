namespace Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;

    public interface Ir
    {
        RedBlackTree<IpIndexElement, IrParameterElement> Value { get; }

        Money GetElementAt(
            IpIndexElement pIndexElement);

        decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement);
    }
}