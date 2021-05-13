namespace Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedOperatingRooms;

    internal sealed class SurgeonGroupNumberAssignedOperatingRoomsCalculationFactory : ISurgeonGroupNumberAssignedOperatingRoomsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRoomsCalculationFactory()
        {
        }

        public ISurgeonGroupNumberAssignedOperatingRoomsCalculation Create()
        {
            ISurgeonGroupNumberAssignedOperatingRoomsCalculation calculation = null;

            try
            {
                calculation = new SurgeonGroupNumberAssignedOperatingRoomsCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}