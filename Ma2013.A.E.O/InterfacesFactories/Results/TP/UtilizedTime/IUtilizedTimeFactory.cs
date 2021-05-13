namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.UtilizedTime
{
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;

    public interface IUtilizedTimeFactory
    {
        IUtilizedTime Create(
            decimal value);
    }
}