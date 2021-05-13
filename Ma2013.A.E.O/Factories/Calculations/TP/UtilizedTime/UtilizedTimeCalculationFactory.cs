namespace Ma2013.A.E.O.Factories.Calculations.TP.UtilizedTime
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.UtilizedTime;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.UtilizedTime;

    internal sealed class UtilizedTimeCalculationFactory : IUtilizedTimeCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UtilizedTimeCalculationFactory()
        {
        }

        public IUtilizedTimeCalculation Create()
        {
            IUtilizedTimeCalculation calculation = null;

            try
            {
                calculation = new UtilizedTimeCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }   
    }
}