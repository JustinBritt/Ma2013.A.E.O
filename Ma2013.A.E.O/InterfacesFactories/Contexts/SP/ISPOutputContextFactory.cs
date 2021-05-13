namespace Ma2013.A.E.O.InterfacesFactories.Contexts.SP
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.Models.SP;

    public interface ISPOutputContextFactory
    {
        ISPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISPModel SPModel,
            Solution solution);
    }
}