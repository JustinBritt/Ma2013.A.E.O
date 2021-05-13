namespace Ma2013.A.E.O.Classes.ParameterElements.TP.WardObjectiveFunctionWeights
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;

    internal sealed class βParameterElement : IβParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βParameterElement(
            IwIndexElement wIndexElement,
            FhirDecimal value)
        {
            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}