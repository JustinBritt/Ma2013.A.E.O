namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Indices.Common;
    using Ma2013.A.E.O.Factories.Indices.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class IndicesAbstractFactory : IIndicesAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IndicesAbstractFactory()
        {
        }

        public IaFactory CreateaFactory()
        {
            IaFactory factory = null;

            try
            {
                factory = new aFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IdFactory CreatedFactory()
        {
            IdFactory factory = null;

            try
            {
                factory = new dFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IkFactory CreatekFactory()
        {
            IkFactory factory = null;

            try
            {
                factory = new kFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IlFactory CreatelFactory()
        {
            IlFactory factory = null;

            try
            {
                factory = new lFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpFactory CreatepFactory()
        {
            IpFactory factory = null;

            try
            {
                factory = new pFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrFactory CreaterFactory()
        {
            IrFactory factory = null;

            try
            {
                factory = new rFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsFactory CreatesFactory()
        {
            IsFactory factory = null;

            try
            {
                factory = new sFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IwFactory CreatewFactory()
        {
            IwFactory factory = null;

            try
            {
                factory = new wFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}