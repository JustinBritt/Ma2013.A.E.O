namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.CrossJoins.Common;
    using Ma2013.A.E.O.Factories.CrossJoins.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinsAbstractFactory()
        {
        }

        public IarFactory CreatearFactory()
        {
            IarFactory factory = null;

            try
            {
                factory = new arFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IpaFactory CreatepaFactory()
        {
            IpaFactory factory = null;

            try
            {
                factory = new paFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IrkFactory CreaterkFactory()
        {
            IrkFactory factory = null;

            try
            {
                factory = new rkFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsaFactory CreatesaFactory()
        {
            IsaFactory factory = null;

            try
            {
                factory = new saFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsarFactory CreatesarFactory()
        {
            IsarFactory factory = null;

            try
            {
                factory = new sarFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IsarkFactory CreatesarkFactory()
        {
            IsarkFactory factory = null;

            try
            {
                factory = new sarkFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IskFactory CreateskFactory()
        {
            IskFactory factory = null;

            try
            {
                factory = new skFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }

        public IwdFactory CreatewdFactory()
        {
            IwdFactory factory = null;

            try
            {
                factory = new wdFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return factory;
        }
    }
}