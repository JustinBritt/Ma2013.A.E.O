namespace Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.WardObjectiveFunctionWeights
{
    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;

    public interface IβParameterElementFactory
    {
        IβParameterElement Create(
            IwIndexElement wIndexElement,
            INullableValue<decimal> value);
    }
}