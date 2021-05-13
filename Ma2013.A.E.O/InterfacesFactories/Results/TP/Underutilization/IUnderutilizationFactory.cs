namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.Underutilization
{
    using Ma2013.A.E.O.Interfaces.Results.TP.Underutilization;

    public interface IUnderutilizationFactory
    {
        IUnderutilization Create(
            decimal value);
    }
}