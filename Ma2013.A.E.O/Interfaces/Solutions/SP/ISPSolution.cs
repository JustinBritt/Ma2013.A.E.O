namespace Ma2013.A.E.O.Interfaces.Solutions.SP
{
    using System.Threading.Tasks;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Configurations.SP;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.SolverConfigurations;

    public interface ISPSolution
    {
        Task<ISPOutputContext> Solve(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            ISPConfiguration SPConfiguration,
            ISPInputContext SPInputContext,
            ISolverConfiguration solverConfiguration);
    }
}