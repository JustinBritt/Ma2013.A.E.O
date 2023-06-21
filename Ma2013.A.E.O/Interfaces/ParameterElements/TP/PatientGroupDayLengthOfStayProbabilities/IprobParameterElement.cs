namespace Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface IprobParameterElement
    {
        IpIndexElement pIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}