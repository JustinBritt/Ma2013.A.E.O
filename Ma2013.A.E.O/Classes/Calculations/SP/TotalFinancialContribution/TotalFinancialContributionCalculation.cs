namespace Ma2013.A.E.O.Classes.Calculations.SP.TotalFinancialContribution
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.TotalFinancialContribution;

    internal sealed class TotalFinancialContributionCalculation : ITotalFinancialContributionCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalFinancialContributionCalculation()
        {
        }

        public ITotalFinancialContribution Calculate(
            ITotalFinancialContributionFactory totalFinancialContributionFactory,
            Ipa pa,
            Ir r,
            ISPx x)
        {
            return totalFinancialContributionFactory.Create(
                pa.Value
                .Select(
                    i =>
                    r.GetElementAtAsdecimal(
                        i.pIndexElement)
                    *
                    (decimal)x.GetElementAt(
                        i.pIndexElement,
                        i.aIndexElement))
                .Sum());
        }
    }
}