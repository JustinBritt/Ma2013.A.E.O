namespace Ma2013.A.E.O.Classes.Configurations.SP
{
    using log4net;

    using OPTANO.Modeling.Optimization.Configuration;

    using Ma2013.A.E.O.Interfaces.Configurations.SP;

    internal sealed class SPConfiguration : ISPConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPConfiguration(
            Configuration configuration)
        {
            this.Value = configuration;
        }

        public Configuration Value { get; }
    }
}