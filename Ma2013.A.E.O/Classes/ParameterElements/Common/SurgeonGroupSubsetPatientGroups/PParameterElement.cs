namespace Ma2013.A.E.O.Classes.ParameterElements.Common.SurgeonGroupSubsetPatientGroups
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;

    internal sealed class PParameterElement : IPParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PParameterElement(
            IsIndexElement sIndexElement,
            IpIndexElement pIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.pIndexElement = pIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IpIndexElement pIndexElement { get; }
    }
}