namespace Ma2013.A.E.O.Classes.Calculations.TP.UnutilizedTime
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.UnutilizedTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UnutilizedTime;
    
    internal sealed class UnutilizedTimeCalculation : IUnutilizedTimeCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UnutilizedTimeCalculation()
        {
        }

        public IUnutilizedTime Calculate(
            IUnutilizedTimeFactory unutilizedTimeFactory,
            ITotalTime totalTime,
            IUtilizedTime utilizedTime)
        {
            return unutilizedTimeFactory.Create(
                totalTime.Value 
                - 
                utilizedTime.Value);
        }
    }
}