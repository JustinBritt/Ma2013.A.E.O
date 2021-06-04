namespace Ma2013.A.E.O.Factories.Calculations.TP.DayBedRequirementMeans
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansCalculationFactory : IDayBedRequirementMeansCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansCalculationFactory()
        {
        }

        public IDayBedRequirementMeansCalculation Create()
        {
            IDayBedRequirementMeansCalculation calculation = null;

            try
            {
                calculation = new DayBedRequirementMeansCalculation();
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