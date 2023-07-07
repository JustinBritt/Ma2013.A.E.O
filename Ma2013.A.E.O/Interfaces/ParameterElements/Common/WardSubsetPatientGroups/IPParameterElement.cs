namespace Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IPParameterElement
    {
        IwIndexElement wIndexElement { get; }

        ImmutableSortedSet<IpIndexElement> Value { get; }
    }
}