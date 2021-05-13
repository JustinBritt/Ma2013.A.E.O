namespace Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory : ISurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysResultElementCalculationFactory()
        {
        }

        public ISurgeonGroupNumberAssignedActiveDaysResultElementCalculation Create()
        {
            ISurgeonGroupNumberAssignedActiveDaysResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonGroupNumberAssignedActiveDaysResultElementCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}