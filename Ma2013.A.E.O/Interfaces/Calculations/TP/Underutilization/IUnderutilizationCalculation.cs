namespace Ma2013.A.E.O.Interfaces.Calculations.TP.Underutilization
{
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.Underutilization;
    using Ma2013.A.E.O.Interfaces.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.Underutilization;

    public interface IUnderutilizationCalculation
    {
        IUnderutilization Calculate(
            IUnderutilizationFactory underutilizationFactory,
            ITotalTime totalTime,
            IUnutilizedTime unutilizedTime);
    }
}