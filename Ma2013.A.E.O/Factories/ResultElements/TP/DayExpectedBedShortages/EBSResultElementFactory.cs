namespace Ma2013.A.E.O.Factories.ResultElements.TP.DayExpectedBedShortages
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;

    internal sealed class EBSResultElementFactory : IEBSResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElementFactory()
        {
        }

        public IEBSResultElement Create(
            IdIndexElement dIndexElement,
            decimal value)
        {
            IEBSResultElement resultElement = null;

            try
            {
                resultElement = new EBSResultElement(
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