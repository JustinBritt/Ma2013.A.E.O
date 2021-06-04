namespace Ma2013.A.E.O.Factories.Solutions.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Solutions.TP;
    using Ma2013.A.E.O.Interfaces.Solutions.TP;
    using Ma2013.A.E.O.InterfacesFactories.Solutions.TP;

    internal sealed class TPSolutionFactory : ITPSolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPSolutionFactory()
        {
        }

        public ITPSolution Create()
        {
            ITPSolution solution = null;

            try
            {
                solution = new TPSolution();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}