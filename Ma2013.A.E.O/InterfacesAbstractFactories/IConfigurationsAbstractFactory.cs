namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.Configurations.SP;
    using Ma2013.A.E.O.InterfacesFactories.Configurations.TP;

    public interface IConfigurationsAbstractFactory
    {
        ISPConfigurationFactory CreateSPConfigurationFactory();

        ITPConfigurationFactory CreateTPConfigurationFactory();
    }
}