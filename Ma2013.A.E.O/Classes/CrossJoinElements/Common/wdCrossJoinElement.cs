namespace Ma2013.A.E.O.Classes.CrossJoinElements.Common
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class wdCrossJoinElement : IwdCrossJoinElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wdCrossJoinElement(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement)
        {
            this.wIndexElement = wIndexElement;

            this.dIndexElement = dIndexElement;
        }

        public IwIndexElement wIndexElement { get; }

        public IdIndexElement dIndexElement { get; }
    }
}