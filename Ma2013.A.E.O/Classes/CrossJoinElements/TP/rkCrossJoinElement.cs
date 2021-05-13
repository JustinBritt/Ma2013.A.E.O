namespace Ma2013.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class rkCrossJoinElement : IrkCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rkCrossJoinElement(
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            this.rIndexElement = rIndexElement;

            this.kIndexElement = kIndexElement;
        }

        public IrIndexElement rIndexElement { get; }

        public IkIndexElement kIndexElement { get; }
    }
}