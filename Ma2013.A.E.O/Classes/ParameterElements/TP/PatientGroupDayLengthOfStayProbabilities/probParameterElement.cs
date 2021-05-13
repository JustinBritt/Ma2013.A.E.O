namespace Ma2013.A.E.O.Classes.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;

    internal sealed class probParameterElement : IprobParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public probParameterElement(
            IpIndexElement pIndexElement,
            IlIndexElement lIndexElement,
            FhirDecimal value)
        {
            this.pIndexElement = pIndexElement;

            this.lIndexElement = lIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public FhirDecimal Value { get; }
    }
}