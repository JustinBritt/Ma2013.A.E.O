namespace Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;

    internal sealed class SurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory : ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation Create()
        {
            ISurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonGroupNumberAssignedOperatingRoomsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return calculation;
        }
    }
}