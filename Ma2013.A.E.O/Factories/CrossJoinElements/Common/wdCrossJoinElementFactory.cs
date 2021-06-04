namespace Ma2013.A.E.O.Factories.CrossJoinElements.Common
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common;

    internal sealed class wdCrossJoinElementFactory : IwdCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wdCrossJoinElementFactory()
        {
        }

        public IwdCrossJoinElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement)
        {
            IwdCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new wdCrossJoinElement(
                    wIndexElement,
                    dIndexElement);
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