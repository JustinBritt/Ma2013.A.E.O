namespace Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysCalculationFactory : ISurgeonGroupNumberAssignedActiveDaysCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysCalculationFactory()
        {
        }

        public ISurgeonGroupNumberAssignedActiveDaysCalculation Create()
        {
            ISurgeonGroupNumberAssignedActiveDaysCalculation calculation = null;

            try
            {
                calculation = new SurgeonGroupNumberAssignedActiveDaysCalculation();
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