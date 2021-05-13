namespace Ma2013.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class paCrossJoinElement : IpaCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public paCrossJoinElement(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement)
        {
            this.pIndexElement = pIndexElement;

            this.aIndexElement = aIndexElement;
        }

        public IpIndexElement pIndexElement { get; }

        public IaIndexElement aIndexElement { get; }
    }
}