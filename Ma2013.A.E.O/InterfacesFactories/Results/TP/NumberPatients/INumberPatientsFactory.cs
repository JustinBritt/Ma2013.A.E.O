namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.NumberPatients
{
    using Ma2013.A.E.O.Interfaces.Results.TP.NumberPatients;

    public interface INumberPatientsFactory
    {
        INumberPatients Create(
            int value);
    }
}