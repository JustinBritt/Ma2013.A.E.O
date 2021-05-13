namespace Ma2013.A.E.O.Classes.Calculations.TP.DayBedRequirementMeans
{
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.Calculations.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansResultElementCalculation : IDayBedRequirementMeansResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansResultElementCalculation()
        {
        }

        public IDayBedRequirementMeansResultElement Calculate(
            IDayBedRequirementMeansResultElementFactory dayBedRequirementMeansResultElementFactory,
            IdIndexElement dIndexElement,
            Iμ μ)
        {
            return dayBedRequirementMeansResultElementFactory.Create(
                dIndexElement,
                μ.Value
                .Where(a => a.dIndexElement == dIndexElement)
                .Select(a => a.Value)
                .Sum());
        }
    }
}