namespace Ma2013.A.E.O.Classes.Solutions.SP
{
    using System.Threading.Tasks;

    using log4net;

    using OPTANO.Modeling.Common;
    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Interfaces;

    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Configurations.SP;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.Models.SP;
    using Ma2013.A.E.O.Interfaces.Solutions.SP;
    using Ma2013.A.E.O.Interfaces.SolverConfigurations;

    internal sealed class SPSolution : ISPSolution
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPSolution()
        {
        }

        public Task<ISPOutputContext> Solve(
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
            ISolverConfiguration solverConfiguration)
        {
            ISPOutputContext SPOutputContext = null;

            return Task.Run(() => 
            {
                using (ModelScope modelScope = dependenciesAbstractFactory.CreateModelScopeFactory().Create(SPConfiguration.Value))
                {
                    ISPModel model = modelsAbstractFactory.CreateSPModelFactory().Create(
                        constraintElementsAbstractFactory,
                        constraintsAbstractFactory,
                        crossJoinElementsAbstractFactory,
                        crossJoinsAbstractFactory,
                        dependenciesAbstractFactory,
                        indexElementsAbstractFactory,
                        indicesAbstractFactory,
                        objectiveFunctionsAbstractFactory,
                        parameterElementsAbstractFactory,
                        parametersAbstractFactory,
                        variablesAbstractFactory,
                        SPInputContext);

                    using (ISolver solver = dependenciesAbstractFactory.CreateSolverFactory().Create(solverConfiguration))
                    {
                        Solution solution = solver?.Solve(model?.Model);

                        if (solution?.ModelStatus == OPTANO.Modeling.Optimization.Solver.ModelStatus.Feasible)
                        {
                            model.Model.VariableCollections.ForEach(vc => vc.SetVariableValues(solution.VariableValues));

                            SPOutputContext = contextsAbstractFactory.CreateSPOutputContextFactory().Create(
                                calculationsAbstractFactory,
                                dependenciesAbstractFactory,
                                resultElementsAbstractFactory,
                                resultsAbstractFactory,
                                model,
                                solution);
                        }
                    }
                }

                return SPOutputContext;
            });
        }
    }
}