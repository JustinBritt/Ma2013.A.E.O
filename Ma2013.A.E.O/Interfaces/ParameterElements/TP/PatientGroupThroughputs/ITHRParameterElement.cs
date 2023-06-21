namespace Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ITHRParameterElement
    {
        IpIndexElement pIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}