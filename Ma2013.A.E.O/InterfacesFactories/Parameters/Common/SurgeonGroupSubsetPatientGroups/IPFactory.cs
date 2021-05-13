namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;

    public interface IPFactory
    {
        IP Create(
            ImmutableList<IPParameterElement> value);
    }
}