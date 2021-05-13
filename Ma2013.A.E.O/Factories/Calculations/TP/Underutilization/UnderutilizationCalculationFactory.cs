namespace Ma2013.A.E.O.Factories.Calculations.TP.Underutilization
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.Underutilization;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.Underutilization;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.Underutilization;

    internal sealed class UnderutilizationCalculationFactory : IUnderutilizationCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UnderutilizationCalculationFactory()
        {
        }

        public IUnderutilizationCalculation Create()
        {
            IUnderutilizationCalculation calculation = null;

            try
            {
                calculation = new UnderutilizationCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}