namespace Ma2013.A.E.O.InterfacesFactories.Results.SP.TotalFinancialContribution
{
    using Ma2013.A.E.O.Interfaces.Results.SP.TotalFinancialContribution;

    public interface ITotalFinancialContributionFactory
    {
        ITotalFinancialContribution Create(
            decimal value);
    }
}