namespace Ma2013.A.E.O.Classes.ParameterElements.TP.WardObjectiveFunctionWeights
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;

    internal sealed class γParameterElement : IγParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γParameterElement(
            IwIndexElement wIndexElement,
            INullableValue<decimal> value)
        {
            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}