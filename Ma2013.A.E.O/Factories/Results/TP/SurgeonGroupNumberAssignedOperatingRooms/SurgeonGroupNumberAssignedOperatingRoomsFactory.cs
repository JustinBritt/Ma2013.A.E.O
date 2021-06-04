namespace Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;

    internal sealed class SurgeonGroupNumberAssignedOperatingRoomsFactory : ISurgeonGroupNumberAssignedOperatingRoomsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRoomsFactory()
        {
        }

        public ISurgeonGroupNumberAssignedOperatingRooms Create(
            ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> value)
        {
            ISurgeonGroupNumberAssignedOperatingRooms result = null;

            try
            {
                result = new SurgeonGroupNumberAssignedOperatingRooms(
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