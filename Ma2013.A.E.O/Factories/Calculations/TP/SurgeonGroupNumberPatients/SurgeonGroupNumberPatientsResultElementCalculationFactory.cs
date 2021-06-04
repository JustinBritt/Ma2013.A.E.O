namespace Ma2013.A.E.O.Factories.Calculations.TP.SurgeonGroupNumberPatients
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsResultElementCalculationFactory : ISurgeonGroupNumberPatientsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsResultElementCalculationFactory()
        {
        }

        public ISurgeonGroupNumberPatientsResultElementCalculation Create()
        {
            ISurgeonGroupNumberPatientsResultElementCalculation calculation = null;

            try
            {
                calculation = new SurgeonGroupNumberPatientsResultElementCalculation();
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