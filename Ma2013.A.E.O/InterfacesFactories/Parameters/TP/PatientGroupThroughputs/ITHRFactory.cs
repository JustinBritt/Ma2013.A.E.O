namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupThroughputs
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;

    public interface ITHRFactory
    {
        ITHR Create(
            ImmutableList<ITHRParameterElement> value);
    }
}