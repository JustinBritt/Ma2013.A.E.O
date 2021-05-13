namespace Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization.Interfaces;

    using Ma2013.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverFactory
    {
        ISolver Create(
            ISolverConfiguration solverConfiguration);
    }
}