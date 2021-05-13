namespace Ma2013.A.E.O.Interfaces.Calculations.TP.DayExpectedBedShortages
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayExpectedBedShortages;

    public interface IEBSCalculation
    {
        IEBS Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IEBSFactory EBSFactory,
            IEBSResultElementCalculation EBSResultElementCalculation,
            Id d,
            Iw w,
            IBEDS BEDS,
            Iμ μ,
            IVariance Variance);
    }
}