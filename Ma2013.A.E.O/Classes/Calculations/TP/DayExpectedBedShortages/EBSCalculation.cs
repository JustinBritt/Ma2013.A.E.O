namespace Ma2013.A.E.O.Classes.Calculations.TP.DayExpectedBedShortages
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayExpectedBedShortages;

    internal sealed class EBSCalculation : IEBSCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSCalculation()
        {
        }

        public IEBS Calculate(
            IEBSResultElementFactory EBSResultElementFactory,
            IEBSFactory EBSFactory,
            IEBSResultElementCalculation EBSResultElementCalculation,
            Id d,
            Iw w,
            IBEDS BEDS,
            Iμ μ,
            IVariance Variance)
        {
            return EBSFactory.Create(
                d.Value
                .Select(y => EBSResultElementCalculation.Calculate(
                    EBSResultElementFactory,
                    y,
                    w,
                    BEDS,
                    μ,
                    Variance))
                .ToImmutableList());
        }
    }
}