namespace Ma2013.A.E.O.Factories.Calculations.SP.TotalFinancialContribution
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Calculations.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Interfaces.Calculations.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.InterfacesFactories.Calculations.SP.TotalFinancialContribution;

    internal sealed class TotalFinancialContributionCalculationFactory : ITotalFinancialContributionCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalFinancialContributionCalculationFactory()
        {
        }

        public ITotalFinancialContributionCalculation Create()
        {
            ITotalFinancialContributionCalculation calculation = null;

            try
            {
                calculation = new TotalFinancialContributionCalculation();
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