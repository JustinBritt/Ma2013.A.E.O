namespace Ma2013.A.E.O.Classes.ResultElements.TP.WardDayBedRequirementVariances
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances;

    internal sealed class VarianceResultElement : IVarianceResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceResultElement(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value)
        {
            this.wIndexElement = wIndexElement;

            this.dIndexElement = dIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public IdIndexElement dIndexElement { get; }

        public decimal Value { get; }
    }
}