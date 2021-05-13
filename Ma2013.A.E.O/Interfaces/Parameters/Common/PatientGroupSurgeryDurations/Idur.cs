namespace Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;

    public interface Idur
    {
        ImmutableList<IdurParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement);
    }
}