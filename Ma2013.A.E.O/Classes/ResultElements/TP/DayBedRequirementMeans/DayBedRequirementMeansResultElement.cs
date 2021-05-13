namespace Ma2013.A.E.O.Classes.ResultElements.TP.DayBedRequirementMeans
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansResultElement : IDayBedRequirementMeansResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansResultElement(
            IdIndexElement dIndexElement,
            decimal value)
        {
            this.dIndexElement = dIndexElement;

            this.Value = value;
        }

        public IdIndexElement dIndexElement { get; }

        public decimal Value { get; }
    }
}