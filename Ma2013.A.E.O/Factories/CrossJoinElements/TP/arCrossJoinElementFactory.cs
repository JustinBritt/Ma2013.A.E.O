namespace Ma2013.A.E.O.Factories.CrossJoinElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class arCrossJoinElementFactory : IarCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public arCrossJoinElementFactory()
        {
        }

        public IarCrossJoinElement Create(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement)
        {
            IarCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new arCrossJoinElement(
                    aIndexElement,
                    rIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}