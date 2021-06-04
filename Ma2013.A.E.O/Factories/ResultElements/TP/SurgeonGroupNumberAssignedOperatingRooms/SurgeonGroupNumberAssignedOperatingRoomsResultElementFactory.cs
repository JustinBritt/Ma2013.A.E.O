namespace Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;

    internal sealed class SurgeonGroupNumberAssignedOperatingRoomsResultElementFactory : ISurgeonGroupNumberAssignedOperatingRoomsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRoomsResultElementFactory()
        {
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsResultElement Create(
            IsIndexElement sIndexElement,
            int value)
        {
            ISurgeonGroupNumberAssignedOperatingRoomsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonGroupNumberAssignedOperatingRoomsResultElement(
                    sIndexElement,
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