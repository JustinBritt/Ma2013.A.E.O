namespace Ma2013.A.E.O.Factories.Calculations.TP.DayBedRequirementMeans
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansResultElementCalculationFactory : IDayBedRequirementMeansResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansResultElementCalculationFactory()
        {
        }

        public IDayBedRequirementMeansResultElementCalculation Create()
        {
            IDayBedRequirementMeansResultElementCalculation calculation = null;

            try
            {
                calculation = new DayBedRequirementMeansResultElementCalculation();
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