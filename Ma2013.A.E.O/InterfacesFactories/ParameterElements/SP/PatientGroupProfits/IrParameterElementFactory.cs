namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupProfits
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;

    public interface IrParameterElementFactory
    {
        IrParameterElement Create(
            IpIndexElement pIndexElement,
            Money value);
    }
}