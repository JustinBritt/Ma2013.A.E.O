namespace Ma2013.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class saCrossJoinElement : IsaCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public saCrossJoinElement(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.aIndexElement = aIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IaIndexElement aIndexElement { get; }
    }
}