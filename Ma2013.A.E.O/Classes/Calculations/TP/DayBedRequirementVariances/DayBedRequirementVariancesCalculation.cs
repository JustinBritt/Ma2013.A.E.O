namespace Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementVariances
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesCalculation : IDayBedRequirementVariancesCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesCalculation()
        {
        }

        public IDayBedRequirementVariances Calculate(
            IDayBedRequirementVariancesResultElementFactory dayBedRequirementVariancesResultElementFactory,
            IDayBedRequirementVariancesFactory dayBedRequirementVariancesFactory,
            IDayBedRequirementVariancesResultElementCalculation dayBedRequirementVariancesResultElementCalculation,
            Id d,
            IVariance Variance)
        {
            return dayBedRequirementVariancesFactory.Create(
                d.Value
                .Select(y => dayBedRequirementVariancesResultElementCalculation.Calculate(
                    dayBedRequirementVariancesResultElementFactory,
                    y,
                    Variance))
                .ToImmutableList());
        }
    }
}