namespace Ma2013.A.E.O.Factories.Calculations.TP.UnutilizedTime
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.UnutilizedTime;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.UnutilizedTime;

    internal sealed class UnutilizedTimeCalculationFactory : IUnutilizedTimeCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UnutilizedTimeCalculationFactory()
        {
        }

        public IUnutilizedTimeCalculation Create()
        {
            IUnutilizedTimeCalculation calculation = null;

            try
            {
                calculation = new UnutilizedTimeCalculation();
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