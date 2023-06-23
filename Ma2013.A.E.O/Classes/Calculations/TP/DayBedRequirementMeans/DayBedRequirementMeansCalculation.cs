namespace Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementMeans
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansCalculation : IDayBedRequirementMeansCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansCalculation()
        {
        }

        public IDayBedRequirementMeans Calculate(
            IDayBedRequirementMeansResultElementFactory dayBedRequirementMeansResultElementFactory,
            IDayBedRequirementMeansFactory dayBedRequirementMeansFactory,
            IDayBedRequirementMeansResultElementCalculation dayBedRequirementMeansResultElementCalculation,
            Id d,
            Iμ μ)
        {
            return dayBedRequirementMeansFactory.Create(
                d.Value.Values
                .Select(y => dayBedRequirementMeansResultElementCalculation.Calculate(
                    dayBedRequirementMeansResultElementFactory,
                    y,
                    μ))
                .ToImmutableList());
        }
    }
}