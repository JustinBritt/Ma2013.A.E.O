namespace Ma2013.A.E.O.InterfacesAbstractFactories
{
    using Ma2013.A.E.O.InterfacesFactories.SolverConfigurations;

    public interface ISolverConfigurationsAbstractFactory
    {
        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}