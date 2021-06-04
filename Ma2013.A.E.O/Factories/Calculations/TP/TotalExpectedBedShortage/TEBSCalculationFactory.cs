namespace Ma2013.A.E.O.Factories.Calculations.TP.TotalExpectedBedShortage
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.Interfaces.Calculations.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.TP.TotalExpectedBedShortage;

    internal sealed class TEBSCalculationFactory : ITEBSCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TEBSCalculationFactory()
        {
        }

        public ITEBSCalculation Create()
        {
            ITEBSCalculation calculation = null;

            try
            {
                calculation = new TEBSCalculation();
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