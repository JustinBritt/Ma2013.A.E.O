namespace Ma2013.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.Comparers;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;

    public interface IsFactory
    {
        Is Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IsIndexElement> value);
    }
}