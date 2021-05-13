namespace Ma2013.A.E.O.Factories.Calculations.TP.WardNumberAssignedOperatingRooms
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedOperatingRooms;

    internal sealed class WardNumberAssignedOperatingRoomsCalculationFactory : IWardNumberAssignedOperatingRoomsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRoomsCalculationFactory()
        {
        }

        public IWardNumberAssignedOperatingRoomsCalculation Create()
        {
            IWardNumberAssignedOperatingRoomsCalculation calculation = null;

            try
            {
                calculation = new WardNumberAssignedOperatingRoomsCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}