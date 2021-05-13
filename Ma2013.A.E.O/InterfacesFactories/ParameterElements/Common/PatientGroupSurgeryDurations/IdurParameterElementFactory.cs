namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.PatientGroupSurgeryDurations
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;

    public interface IdurParameterElementFactory
    {
        IdurParameterElement Create(
            IpIndexElement pIndexElement,
            Duration value);
    }
}