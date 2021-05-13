namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedRequirementVariances
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances;

    internal sealed class VarianceResultElementFactory : IVarianceResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceResultElementFactory()
        {
        }

        public IVarianceResultElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value)
        {
            IVarianceResultElement resultElement = null;

            try
            {
                resultElement = new VarianceResultElement(
                    wIndexElement,
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