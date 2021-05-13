namespace Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IrParameterElement
    {
        IpIndexElement pIndexElement { get; }

        Money Value { get; }
    }
}