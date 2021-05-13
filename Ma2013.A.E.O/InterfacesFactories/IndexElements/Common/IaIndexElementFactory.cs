namespace Ma2013.A.E.O.InterfacesFactories.IndexElements.Common
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IaIndexElementFactory
    {
        IaIndexElement Create(
            int key,
            FhirDateTime value);
    }
}