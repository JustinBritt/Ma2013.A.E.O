namespace Ma2013.A.E.O.InterfacesFactories.IndexElements.Common
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IsIndexElementFactory
    {
        IsIndexElement Create(
            Organization value);
    }
}