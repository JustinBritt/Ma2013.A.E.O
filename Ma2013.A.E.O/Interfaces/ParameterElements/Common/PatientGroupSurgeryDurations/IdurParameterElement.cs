namespace Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IdurParameterElement
    {
        IpIndexElement pIndexElement { get; }

        Duration Value { get; }
    }
}