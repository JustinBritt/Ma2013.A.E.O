namespace Ma2013.A.E.O.Classes.ParameterElements.Common.WardSubsetPatientGroups
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;

    internal sealed class PParameterElement : IPParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PParameterElement(
            IwIndexElement wIndexElement,
            IpIndexElement pIndexElement)
        {
            this.wIndexElement = wIndexElement;

            this.pIndexElement = pIndexElement;
        }

        public IwIndexElement wIndexElement { get; }

        public IpIndexElement pIndexElement { get; }
    }
}