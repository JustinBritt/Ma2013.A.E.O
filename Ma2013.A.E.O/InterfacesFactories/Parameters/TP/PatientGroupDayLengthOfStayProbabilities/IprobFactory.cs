namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupDayLengthOfStayProbabilities
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;

    public interface IprobFactory
    {
        Iprob Create(
            ImmutableList<IprobParameterElement> value);
    }
}