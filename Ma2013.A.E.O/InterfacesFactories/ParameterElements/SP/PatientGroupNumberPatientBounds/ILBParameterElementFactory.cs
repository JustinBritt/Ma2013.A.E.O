namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupNumberPatientBounds
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;

    public interface ILBParameterElementFactory
    {
        ILBParameterElement Create(
            IpIndexElement pIndexElement,
            INullableValue<int> value);
    }
}