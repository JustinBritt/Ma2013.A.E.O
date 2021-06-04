namespace Ma2013.A.E.O.Factories.Calculations.TP.DayBedRequirementVariances
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesResultElementCalculationFactory : IDayBedRequirementVariancesResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesResultElementCalculationFactory()
        {
        }

        public IDayBedRequirementVariancesResultElementCalculation Create()
        {
            IDayBedRequirementVariancesResultElementCalculation calculation = null;

            try
            {
                calculation = new DayBedRequirementVariancesResultElementCalculation();
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