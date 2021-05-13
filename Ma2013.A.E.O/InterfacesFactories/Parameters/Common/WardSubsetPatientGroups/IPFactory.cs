namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;

    public interface IPFactory
    {
        IP Create(
            ImmutableList<IPParameterElement> value);
    }
}