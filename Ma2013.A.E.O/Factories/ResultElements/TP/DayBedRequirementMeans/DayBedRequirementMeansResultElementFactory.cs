namespace Ma2013.A.E.O.Factories.ResultElements.TP.DayBedRequirementMeans
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansResultElementFactory : IDayBedRequirementMeansResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansResultElementFactory()
        {
        }

        public IDayBedRequirementMeansResultElement Create(
            IdIndexElement dIndexElement,
            decimal value)
        {
            IDayBedRequirementMeansResultElement resultElement = null;

            try
            {
                resultElement = new DayBedRequirementMeansResultElement(
                    dIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}