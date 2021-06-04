namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.Solutions.SP;
    using Ma2013.A.E.O.Factories.Solutions.TP;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.Solutions.SP;
    using Ma2013.A.E.O.InterfacesFactories.Solutions.TP;

    internal sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolutionsAbstractFactory()
        {
        }

        public ISPSolutionFactory CreateSPSolutionFactory()
        {
            ISPSolutionFactory factory = null;

            try
            {
                factory = new SPSolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }

        public ITPSolutionFactory CreateTPSolutionFactory()
        {
            ITPSolutionFactory factory = null;

            try
            {
                factory = new TPSolutionFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}