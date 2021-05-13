namespace Ma2013.A.E.O.Classes.ResultElements.TP.DayBedRequirementVariances
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesResultElement : IDayBedRequirementVariancesResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesResultElement(
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