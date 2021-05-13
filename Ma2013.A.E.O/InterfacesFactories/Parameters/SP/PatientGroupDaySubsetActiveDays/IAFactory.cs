namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;

    public interface IAFactory
    {
        IA Create(
            ImmutableList<IAParameterElement> value);
    }
}