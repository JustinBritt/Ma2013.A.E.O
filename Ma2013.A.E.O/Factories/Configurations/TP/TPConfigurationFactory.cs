namespace Ma2013.A.E.O.Factories.Configurations.TP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Ma2013.A.E.O.Classes.Configurations.TP;
    using Ma2013.A.E.O.Interfaces.Configurations.TP;
    using Ma2013.A.E.O.InterfacesFactories.Configurations.TP;

    internal sealed class TPConfigurationFactory : ITPConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPConfigurationFactory()
        {
        }

        public ITPConfiguration Create(
            Configuration configuration)
        {
            ITPConfiguration TPConfiguration = null;

            try
            {
                TPConfiguration = new TPConfiguration(
                    configuration);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return TPConfiguration;
        }
    }
}