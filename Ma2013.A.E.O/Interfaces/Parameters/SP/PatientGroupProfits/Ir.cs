namespace Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;

    public interface Ir
    {
        ImmutableList<IrParameterElement> Value { get; }

        Money GetElementAt(
            IpIndexElement pIndexElement);

        decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement);
    }
}