namespace Ma2013.A.E.O.InterfacesFactories.Configurations.SP
{
    using OPTANO.Modeling.Optimization.Configuration;

    using Ma2013.A.E.O.Interfaces.Configurations.SP;

    public interface ISPConfigurationFactory
    {
        ISPConfiguration Create(
            Configuration configuration);
    }
}