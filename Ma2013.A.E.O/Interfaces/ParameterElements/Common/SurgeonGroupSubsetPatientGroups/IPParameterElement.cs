namespace Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IPParameterElement
    {
        IsIndexElement sIndexElement { get; }

        ImmutableSortedSet<IpIndexElement> Value { get; }
    }
}