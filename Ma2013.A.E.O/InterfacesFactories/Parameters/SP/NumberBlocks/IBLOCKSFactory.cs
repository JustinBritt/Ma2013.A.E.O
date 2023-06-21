namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.NumberBlocks
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;

    public interface IBLOCKSFactory
    {
        IBLOCKS Create(
            INullableValue<int> value);
    }
}