namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalTime
{
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;

    public interface ITotalTimeFactory
    {
        ITotalTime Create(
            decimal value);
    }
}