namespace Ma2013.A.E.O.Factories.Calculations.TP.TotalTime
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.TotalTime;

    internal sealed class TotalTimeCalculationFactory : ITotalTimeCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalTimeCalculationFactory()
        {
        }

        public ITotalTimeCalculation Create()
        {
            ITotalTimeCalculation calculation = null;

            try
            {
                calculation = new TotalTimeCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}