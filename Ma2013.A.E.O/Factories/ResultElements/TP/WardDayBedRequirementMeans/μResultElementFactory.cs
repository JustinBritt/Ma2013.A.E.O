namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedRequirementMeans
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementMeans;

    internal sealed class μResultElementFactory : IμResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μResultElementFactory()
        {
        }

        public IμResultElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value)
        {
            IμResultElement resultElement = null;

            try
            {
                resultElement = new μResultElement(
                    wIndexElement,
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