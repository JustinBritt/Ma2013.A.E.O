namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.BlockTypeTimeBlockLengths
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;

    public interface ILengthParameterElementFactory
    {
        ILengthParameterElement Create(
            IkIndexElement kIndexElement,
            Duration value);
    }
}