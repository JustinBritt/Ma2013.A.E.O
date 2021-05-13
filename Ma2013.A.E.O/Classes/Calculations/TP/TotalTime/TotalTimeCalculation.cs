namespace Ma2013.A.E.O.Classes.Calculations.TP.TotalTime
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalTime;

    internal sealed class TotalTimeCalculation : ITotalTimeCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalTimeCalculation()
        {
        }

        public ITotalTime Calculate(
            ITotalTimeFactory totalTimeFactory,
            Isark sark,
            ILength Length,
            ITPz z)
        {
            return totalTimeFactory.Create(
                sark.Value
                .Select(w =>
                z.GetElementAtAsint(
                    w.sIndexElement,
                    w.aIndexElement,
                    w.rIndexElement,
                    w.kIndexElement)
                *
                Length.GetElementAtAsdecimal(
                    w.kIndexElement))
                .Sum());
        }
    }
}