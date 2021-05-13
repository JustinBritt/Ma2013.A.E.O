namespace Ma2013.A.E.O.Interfaces.Calculations.TP.UnutilizedTime
{
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UnutilizedTime;

    public interface IUnutilizedTimeCalculation
    {
        IUnutilizedTime Calculate(
            IUnutilizedTimeFactory unutilizedTimeFactory,
            ITotalTime totalTime,
            IUtilizedTime utilizedTime);
    }
}
