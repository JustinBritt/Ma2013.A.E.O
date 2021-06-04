namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.CrossJoinElements.Common;
    using Ma2013.A.E.O.Factories.CrossJoinElements.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoinElements.TP;

    internal sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public CrossJoinElementsAbstractFactory()
        {
        }

        public IarCrossJoinElementFactory CreatearCrossJoinElementFactory()
        {
            IarCrossJoinElementFactory factory = null;

            try
            {
                factory = new arCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IpaCrossJoinElementFactory CreatepaCrossJoinElementFactory()
        {
            IpaCrossJoinElementFactory factory = null;

            try
            {
                factory = new paCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IrkCrossJoinElementFactory CreaterkCrossJoinElementFactory()
        {
            IrkCrossJoinElementFactory factory = null;

            try
            {
                factory = new rkCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsaCrossJoinElementFactory CreatesaCrossJoinElementFactory()
        {
            IsaCrossJoinElementFactory factory = null;

            try
            {
                factory = new saCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsarCrossJoinElementFactory CreatesarCrossJoinElementFactory()
        {
            IsarCrossJoinElementFactory factory = null;

            try
            {
                factory = new sarCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IsarkCrossJoinElementFactory CreatesarkCrossJoinElementFactory()
        {
            IsarkCrossJoinElementFactory factory = null;

            try
            {
                factory = new sarkCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IskCrossJoinElementFactory CreateskCrossJoinElementFactory()
        {
            IskCrossJoinElementFactory factory = null;

            try
            {
                factory = new skCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public IwdCrossJoinElementFactory CreatewdCrossJoinElementFactory()
        {
            IwdCrossJoinElementFactory factory = null;

            try
            {
                factory = new wdCrossJoinElementFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}