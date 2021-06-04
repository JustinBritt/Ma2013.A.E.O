namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardBedOccupancyVariances
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances;

    internal sealed class VarianceResultElementFactory : IVarianceResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceResultElementFactory()
        {
        }

        public IVarianceResultElement Create(
            IwIndexElement wIndexElement,
            decimal value)
        {
            IVarianceResultElement resultElement = null;

            try
            {
                resultElement = new VarianceResultElement(
                    wIndexElement,
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