namespace Ma2013.A.E.O.Factories.Calculations.TP.DayBedRequirementVariances
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesCalculationFactory : IDayBedRequirementVariancesCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesCalculationFactory()
        {
        }

        public IDayBedRequirementVariancesCalculation Create()
        {
            IDayBedRequirementVariancesCalculation calculation = null;

            try
            {
                calculation = new DayBedRequirementVariancesCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}