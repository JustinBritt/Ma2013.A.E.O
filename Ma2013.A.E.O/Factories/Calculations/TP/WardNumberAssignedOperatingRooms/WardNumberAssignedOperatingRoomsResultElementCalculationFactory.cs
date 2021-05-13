namespace Ma2013.A.E.O.Factories.Calculations.TP.WardNumberAssignedOperatingRooms
{
    using System;
 
    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.WardNumberAssignedOperatingRooms;

    internal sealed class WardNumberAssignedOperatingRoomsResultElementCalculationFactory : IWardNumberAssignedOperatingRoomsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRoomsResultElementCalculationFactory()
        {
        }

        public IWardNumberAssignedOperatingRoomsResultElementCalculation Create()
        {
            IWardNumberAssignedOperatingRoomsResultElementCalculation calculation = null;

            try
            {
                calculation = new WardNumberAssignedOperatingRoomsResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}