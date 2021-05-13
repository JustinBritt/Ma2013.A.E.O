namespace Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;

    internal sealed class AParameterElement : IAParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElement(
            IpIndexElement pIndexElement,
            IdIndexElement dIndexElement,
            IaIndexElement aIndexElement)
        {
            this.pIndexElement = pIndexElement;

            this.dIndexElement = dIndexElement;

            this.aIndexElement = aIndexElement;
        }

        public IpIndexElement pIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public IaIndexElement aIndexElement { get; }
    }
}