namespace Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IAParameterElement
    {
        IpIndexElement pIndexElement { get; }

        IaIndexElement aIndexElement { get; }

        ImmutableList<IdIndexElement> Value { get; }
    }
}