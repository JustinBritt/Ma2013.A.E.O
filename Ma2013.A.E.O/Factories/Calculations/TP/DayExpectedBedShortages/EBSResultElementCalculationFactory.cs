namespace Ma2013.A.E.O.Factories.Calculations.TP.DayExpectedBedShortages
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayExpectedBedShortages;

    internal sealed class EBSResultElementCalculationFactory : IEBSResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementCalculationFactory()
        {
        }

        public IEBSResultElementCalculation Create()
        {
            IEBSResultElementCalculation calculation = null;

            try
            {
                calculation = new EBSResultElementCalculation();
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