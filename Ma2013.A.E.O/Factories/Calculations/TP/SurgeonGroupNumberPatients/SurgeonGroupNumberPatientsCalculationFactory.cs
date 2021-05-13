namespace Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberPatients
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsCalculationFactory : ISurgeonGroupNumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsCalculationFactory()
        {
        }

        public ISurgeonGroupNumberPatientsCalculation Create()
        {
            ISurgeonGroupNumberPatientsCalculation calculation = null;

            try
            {
                calculation = new SurgeonGroupNumberPatientsCalculation();
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return calculation;
        }
    }
}