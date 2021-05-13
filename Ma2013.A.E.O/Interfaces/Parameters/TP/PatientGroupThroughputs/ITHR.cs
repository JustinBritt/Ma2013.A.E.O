namespace Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;

    public interface ITHR
    {
        ImmutableList<ITHRParameterElement> Value { get; }

        int GetElementAtAsint(
            IpIndexElement pIndexElement);
    }
}