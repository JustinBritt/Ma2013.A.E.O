namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Contexts.SP;
    using Ma2013.A.E.O.Factories.Contexts.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.SP;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.TP;

    internal sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ContextsAbstractFactory()
        {
        }

        public ISPInputContextFactory CreateSPInputContextFactory()
        {
            ISPInputContextFactory factory = null;

            try
            {
                factory = new SPInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ISPOutputContextFactory CreateSPOutputContextFactory()
        {
            ISPOutputContextFactory factory = null;

            try
            {
                factory = new SPOutputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPInputContextFactory CreateTPInputContextFactory()
        {
            ITPInputContextFactory factory = null;

            try
            {
                factory = new TPInputContextFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPOutputContextFactory CreateTPOutputContextFactory()
        {
            ITPOutputContextFactory factory = null;

            try
            {
                factory = new TPOutputContextFactory();
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