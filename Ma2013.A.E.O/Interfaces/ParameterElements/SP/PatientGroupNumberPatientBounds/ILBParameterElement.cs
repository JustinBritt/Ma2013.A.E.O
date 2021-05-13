namespace Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ILBParameterElement
    {
        IpIndexElement pIndexElement { get; }

        PositiveInt Value { get; }
    }
}