namespace Ma2013.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class skCrossJoinElement : IskCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public skCrossJoinElement(
            IsIndexElement sIndexElement,
            IkIndexElement kIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}