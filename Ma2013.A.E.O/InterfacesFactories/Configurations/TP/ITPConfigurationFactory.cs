namespace Ma2013.A.E.O.InterfacesFactories.Configurations.TP
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Ma2013.A.E.O.Interfaces.Configurations.TP;

    public interface ITPConfigurationFactory
    {
        ITPConfiguration Create(
            Configuration configuration);
    }
}