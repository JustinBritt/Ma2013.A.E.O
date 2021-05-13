namespace Ma2013.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;

    public interface IdFactory
    {
        Id Create(
            ImmutableList<IdIndexElement> value);
    }
}