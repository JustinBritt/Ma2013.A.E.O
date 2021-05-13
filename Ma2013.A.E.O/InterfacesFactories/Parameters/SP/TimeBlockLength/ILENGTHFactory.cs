namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.TimeBlockLength
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;

    public interface ILENGTHFactory
    {
        ILENGTH Create(
            Duration value);
    }
}