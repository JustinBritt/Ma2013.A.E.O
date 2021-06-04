namespace Ma2013.A.E.O.Factories.Results.SP.TotalFinancialContribution
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Interfaces.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.TotalFinancialContribution;

    internal sealed class TotalFinancialContributionFactory : ITotalFinancialContributionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalFinancialContributionFactory()
        {
        }

        public ITotalFinancialContribution Create(
            decimal value)
        {
            ITotalFinancialContribution result = null;

            try
            {
                result = new TotalFinancialContribution(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}