namespace Ma2013.A.E.O.Factories.Contexts.SP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Contexts.SP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.Models.SP;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.SP;

    internal sealed class SPOutputContextFactory : ISPOutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPOutputContextFactory()
        {
        }

        public ISPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISPModel SPModel,
            Solution solution)
        {
            ISPOutputContext context = null;

            try
            {
                context = new SPOutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    SPModel,
                    solution);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}