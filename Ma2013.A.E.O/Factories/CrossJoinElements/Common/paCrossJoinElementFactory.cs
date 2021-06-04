namespace Ma2013.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class paCrossJoinElementFactory : IpaCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public paCrossJoinElementFactory()
        {
        }

        public IpaCrossJoinElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement)
        {
            IpaCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new paCrossJoinElement(
                    pIndexElement,
                    aIndexElement);
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