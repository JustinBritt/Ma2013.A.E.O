namespace Ma2013.A.E.O.Classes.ParameterElements.TP.PatientGroupThroughputs
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;

    internal sealed class THRParameterElement : ITHRParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public THRParameterElement(
            IpIndexElement pIndexElement,
            INullableValue<int> value)
        {
            this.pIndexElement = pIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public INullableValue<int> Value { get; }
    }
}