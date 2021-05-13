namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupThroughputs
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;

    public interface ITHRParameterElementFactory
    {
        ITHRParameterElement Create(
            IpIndexElement pIndexElement,
            PositiveInt value);
    }
}