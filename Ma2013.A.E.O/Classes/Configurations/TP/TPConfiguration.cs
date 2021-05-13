namespace Ma2013.A.E.O.Classes.Configurations.TP
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Ma2013.A.E.O.Interfaces.Configurations.TP;

    internal sealed class TPConfiguration : ITPConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPConfiguration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}