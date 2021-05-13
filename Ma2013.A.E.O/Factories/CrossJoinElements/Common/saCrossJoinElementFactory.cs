namespace Ma2013.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class saCrossJoinElementFactory : IsaCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public saCrossJoinElementFactory()
        {
        }

        public IsaCrossJoinElement Create(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement)
        {
            IsaCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new saCrossJoinElement(
                    sIndexElement,
                    aIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoinElement;
        }
    }
}