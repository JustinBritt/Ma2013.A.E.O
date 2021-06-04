namespace Ma2013.A.E.O.Factories.Calculations.TP.DayExpectedBedShortages
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayExpectedBedShortages;

    internal sealed class EBSCalculationFactory : IEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSCalculationFactory()
        {
        }

        public IEBSCalculation Create()
        {
            IEBSCalculation calculation = null;

            try
            {
                calculation = new EBSCalculation();
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