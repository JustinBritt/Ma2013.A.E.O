namespace Ma2013.A.E.O.Interfaces.Calculations.SP.TotalFinancialContribution
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Results.SP.TotalFinancialContribution;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.TotalFinancialContribution;

    public interface ITotalFinancialContributionCalculation
    {
        ITotalFinancialContribution Calculate(
            ITotalFinancialContributionFactory totalFinancialContributionFactory,
            Ipa pa,
            Ir r,
            ISPx x);
    }
}