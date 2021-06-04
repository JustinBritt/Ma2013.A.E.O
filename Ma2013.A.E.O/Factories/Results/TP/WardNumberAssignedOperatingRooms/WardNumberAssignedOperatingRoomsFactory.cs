namespace Ma2013.A.E.O.Factories.Results.TP.WardNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedOperatingRooms;

    internal sealed class WardNumberAssignedOperatingRoomsFactory : IWardNumberAssignedOperatingRoomsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRoomsFactory()
        {
        }

        public IWardNumberAssignedOperatingRooms Create(
            ImmutableList<IWardNumberAssignedOperatingRoomsResultElement> value)
        {
            IWardNumberAssignedOperatingRooms result = null;

            try
            {
                result = new WardNumberAssignedOperatingRooms(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}