namespace Ma2013.A.E.O.Classes.Calculations.TP.Underutilization
{
    using Ma2013.A.E.O.Interfaces.Calculations.TP.Underutilization;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.Underutilization;
    using Ma2013.A.E.O.Interfaces.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.Underutilization;

    internal sealed class UnderutilizationCalculation : IUnderutilizationCalculation
    {
        public UnderutilizationCalculation()
        {
        }

        public IUnderutilization Calculate(
            IUnderutilizationFactory underutilizationFactory,
            ITotalTime totalTime,
            IUnutilizedTime unutilizedTime)
        {
            return underutilizationFactory.Create(
                unutilizedTime.Value
                /
                totalTime.Value);
        }
    }
}