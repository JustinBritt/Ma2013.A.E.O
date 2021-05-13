namespace Ma2013.A.E.O.Classes.ParameterElements.Common.PatientGroupSurgeryDurations
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;

    internal sealed class durParameterElement : IdurParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public durParameterElement(
            IpIndexElement pIndexElement,
            Duration value)
        {
            this.pIndexElement = pIndexElement;

            this.Value = value;
        }

        public IpIndexElement pIndexElement { get; }

        public Duration Value { get; }
    }
}