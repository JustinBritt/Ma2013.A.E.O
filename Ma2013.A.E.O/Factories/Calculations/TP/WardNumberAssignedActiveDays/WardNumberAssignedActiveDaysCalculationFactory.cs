namespace Ma2013.A.E.O.Factories.Calculations.TP.WardNumberAssignedActiveDays
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedActiveDays;

    internal sealed class WardNumberAssignedActiveDaysCalculationFactory : IWardNumberAssignedActiveDaysCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedActiveDaysCalculationFactory()
        {
        }

        public IWardNumberAssignedActiveDaysCalculation Create()
        {
            IWardNumberAssignedActiveDaysCalculation calculation = null;

            try
            {
                calculation = new WardNumberAssignedActiveDaysCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}