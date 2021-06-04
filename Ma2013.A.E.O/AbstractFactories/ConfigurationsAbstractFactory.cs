namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Configurations.SP;
    using Ma2013.A.E.O.Factories.Configurations.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Configurations.SP;
    using Ma2013.A.E.O.InterfacesFactories.Configurations.TP;

    internal sealed class ConfigurationsAbstractFactory : IConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfigurationsAbstractFactory()
        {
        }

        public ISPConfigurationFactory CreateSPConfigurationFactory()
        {
            ISPConfigurationFactory factory = null;

            try
            {
                factory = new SPConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPConfigurationFactory CreateTPConfigurationFactory()
        {
            ITPConfigurationFactory factory = null;

            try
            {
                factory = new TPConfigurationFactory();
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