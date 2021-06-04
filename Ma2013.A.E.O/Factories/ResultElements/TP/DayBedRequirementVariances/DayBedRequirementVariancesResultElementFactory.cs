namespace Ma2013.A.E.O.Factories.ResultElements.TP.DayBedRequirementVariances
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesResultElementFactory : IDayBedRequirementVariancesResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesResultElementFactory()
        {
        }

        public IDayBedRequirementVariancesResultElement Create(
            IdIndexElement dIndexElement,
            decimal value)
        {
            IDayBedRequirementVariancesResultElement resultElement = null;

            try
            {
                resultElement = new DayBedRequirementVariancesResultElement(
                    dIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}