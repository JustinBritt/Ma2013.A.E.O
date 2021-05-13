namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardDayBedAvailabilityDeviations
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δMinusResultElementFactory : IδMinusResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δMinusResultElementFactory()
        {
        }

        public IδMinusResultElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value)
        {
            IδMinusResultElement resultElement = null;

            try
            {
                resultElement = new δMinusResultElement(
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