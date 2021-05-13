namespace Ma2013.A.E.O.Interfaces.Results.TP.NumberPatients
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface INumberPatients
    {
        int Value { get; }

        INullableValue<int> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}