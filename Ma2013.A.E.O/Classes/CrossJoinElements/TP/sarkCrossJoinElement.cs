namespace Ma2013.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class sarkCrossJoinElement : IsarkCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sarkCrossJoinElement(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            this.sIndexElement = sIndexElement;

            this.aIndexElement = aIndexElement;

            this.rIndexElement = rIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IsIndexElement sIndexElement { get; }

        public IaIndexElement aIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}