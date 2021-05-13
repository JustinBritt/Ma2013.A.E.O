namespace Ma2013.A.E.O.Classes.CrossJoinElements.TP
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class arCrossJoinElement : IarCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public arCrossJoinElement(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement)
        {
            this.aIndexElement = aIndexElement;

            this.rIndexElement = rIndexElement;
        }

        public IaIndexElement aIndexElement { get; }

        public IrIndexElement rIndexElement { get; }
    }
}