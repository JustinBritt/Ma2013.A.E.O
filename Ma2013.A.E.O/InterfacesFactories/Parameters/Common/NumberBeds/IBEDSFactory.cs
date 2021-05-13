namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.NumberBeds
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;

    public interface IBEDSFactory
    {
        IBEDS Create(
            PositiveInt value);
    }
}