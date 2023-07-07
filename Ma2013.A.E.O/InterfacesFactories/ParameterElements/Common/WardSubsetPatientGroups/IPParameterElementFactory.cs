namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;

    public interface IPParameterElementFactory
    {
        IPParameterElement Create(
            IwIndexElement wIndexElement,
            ImmutableSortedSet<IpIndexElement> value);
    }
}