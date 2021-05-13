namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;

    public interface IprobParameterElementFactory
    {
        IprobParameterElement Create(
            IpIndexElement pIndexElement,
            IlIndexElement lIndexElement,
            FhirDecimal value);
    }
}