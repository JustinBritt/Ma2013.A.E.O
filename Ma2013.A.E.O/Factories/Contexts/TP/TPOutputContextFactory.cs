namespace Ma2013.A.E.O.Factories.Contexts.TP
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Contexts.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.Interfaces.Contexts.TP;
    using Ma2013.A.E.O.Interfaces.Models.TP;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.TP;

    internal sealed class TPOutputContextFactory : ITPOutputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPOutputContextFactory()
        {
        }

        public ITPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ITPModel TPModel,
            Solution solution)
        {
            ITPOutputContext context = null;

            try
            {
                context = new TPOutputContext(
                    calculationsAbstractFactory,
                    dependenciesAbstractFactory,
                    resultElementsAbstractFactory,
                    resultsAbstractFactory,
                    TPModel,
                    solution);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return context;
        }
    }
}