namespace Ma2013.A.E.O.InterfacesFactories.SolverConfigurations
{
    using Ma2013.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration);
    }
}