namespace Ma2013.A.E.O.Interfaces.Calculations.TP.DayExpectedBedShortages
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;

    public interface IEBSResultElementCalculation
    {
        IEBSResultElement Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IdIndexElement dIndexElement,
            Iw w,
            IBEDS BEDS,
            Iμ μ,
            IVariance Variance);
    }
}