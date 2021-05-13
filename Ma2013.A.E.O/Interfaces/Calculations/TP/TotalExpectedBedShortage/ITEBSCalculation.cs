namespace Ma2013.A.E.O.Interfaces.Calculations.TP.TotalExpectedBedShortage
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalExpectedBedShortage;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalExpectedBedShortage;

    public interface ITEBSCalculation
    {
        ITEBS Calculate(
            ITEBSFactory TEBSFactory,
            Id d,
            IEBS EBS);
    }
}