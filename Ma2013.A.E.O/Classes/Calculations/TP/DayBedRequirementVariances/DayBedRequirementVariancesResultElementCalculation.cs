namespace Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementVariances
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesResultElementCalculation : IDayBedRequirementVariancesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesResultElementCalculation()
        {
        }

        public IDayBedRequirementVariancesResultElement Calculate(
            IDayBedRequirementVariancesResultElementFactory dayBedRequirementVariancesResultElementFactory,
            IdIndexElement dIndexElement,
            IVariance Variance)
        {
            return dayBedRequirementVariancesResultElementFactory.Create(
                dIndexElement,
                Variance.Value
                .Where(a => a.dIndexElement == dIndexElement)
                .Select(a => a.Value)
                .Sum());
        }
    }
}