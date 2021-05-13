namespace Ma2013.A.E.O.Interfaces.Calculations.TP.TotalTime
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalTime;

    public interface ITotalTimeCalculation
    {
        ITotalTime Calculate(
            ITotalTimeFactory totalTimeFactory,
            Isark sark,
            ILength Length,
            ITPz z);
    }
}