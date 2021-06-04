namespace Ma2013.A.E.O.Factories.Calculations.TP.NumberPatients
{
    using System;
 
    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.NumberPatients;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.NumberPatients;

    internal sealed class NumberPatientsCalculationFactory : INumberPatientsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberPatientsCalculationFactory()
        {
        }

        public INumberPatientsCalculation Create()
        {
            INumberPatientsCalculation calculation = null;

            try
            {
                calculation = new NumberPatientsCalculation();
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