namespace Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization;

    public interface IModelScopeFactory
    {
        ModelScope Create();

        ModelScope Create(
            global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration);
    }
}