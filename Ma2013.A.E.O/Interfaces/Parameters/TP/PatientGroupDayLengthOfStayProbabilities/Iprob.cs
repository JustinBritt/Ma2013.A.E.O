namespace Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;

    public interface Iprob
    {
        ImmutableList<IprobParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement,
            IlIndexElement lIndexElement);
    }
}