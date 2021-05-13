namespace Ma2013.A.E.O.Factories.CrossJoinElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class rkCrossJoinElementFactory : IrkCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rkCrossJoinElementFactory()
        {
        }

        public IrkCrossJoinElement Create(
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            IrkCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new rkCrossJoinElement(
                    rIndexElement,
                    kIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}