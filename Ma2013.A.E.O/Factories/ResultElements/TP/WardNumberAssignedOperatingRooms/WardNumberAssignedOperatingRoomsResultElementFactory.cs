namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedOperatingRooms;

    internal sealed class WardNumberAssignedOperatingRoomsResultElementFactory : IWardNumberAssignedOperatingRoomsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRoomsResultElementFactory()
        {
        }

        public IWardNumberAssignedOperatingRoomsResultElement Create(
            IwIndexElement wIndexElement,
            int value)
        {
            IWardNumberAssignedOperatingRoomsResultElement resultElement = null;

            try
            {
                resultElement = new WardNumberAssignedOperatingRoomsResultElement(
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