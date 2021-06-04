namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardNumberAssignedActiveDays
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays;

    internal sealed class WardNumberAssignedActiveDaysResultElementFactory : IWardNumberAssignedActiveDaysResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedActiveDaysResultElementFactory()
        {
        }

        public IWardNumberAssignedActiveDaysResultElement Create(
            IwIndexElement wIndexElement,
            int value)
        {
            IWardNumberAssignedActiveDaysResultElement resultElement = null;

            try
            {
                resultElement = new WardNumberAssignedActiveDaysResultElement(
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