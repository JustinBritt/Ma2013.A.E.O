namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.PatientGroupSurgeryDurations
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;

    public interface IdurFactory
    {
        Idur Create(
            ImmutableList<IdurParameterElement> value);
    }
}