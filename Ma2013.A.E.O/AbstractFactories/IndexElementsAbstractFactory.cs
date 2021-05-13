namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.IndexElements.Common;
    using Ma2013.A.E.O.Factories.IndexElements.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.TP;

    internal sealed class IndexElementsAbstractFactory : IIndexElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndexElementsAbstractFactory()
        {
        }

        public IaIndexElementFactory CreateaIndexElementFactory()
        {
            IaIndexElementFactory factory = null;

            try
            {
                factory = new aIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IdIndexElementFactory CreatedIndexElementFactory()
        {
            IdIndexElementFactory factory = null;

            try
            {
                factory = new dIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IkIndexElementFactory CreatekIndexElementFactory()
        {
            IkIndexElementFactory factory = null;

            try
            {
                factory = new kIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IlIndexElementFactory CreatelIndexElementFactory()
        {
            IlIndexElementFactory factory = null;

            try
            {
                factory = new lIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpIndexElementFactory CreatepIndexElementFactory()
        {
            IpIndexElementFactory factory = null;

            try
            {
                factory = new pIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrIndexElementFactory CreaterIndexElementFactory()
        {
            IrIndexElementFactory factory = null;

            try
            {
                factory = new rIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsIndexElementFactory CreatesIndexElementFactory()
        {
            IsIndexElementFactory factory = null;

            try
            {
                factory = new sIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IwIndexElementFactory CreatewIndexElementFactory()
        {
            IwIndexElementFactory factory = null;

            try
            {
                factory = new wIndexElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}