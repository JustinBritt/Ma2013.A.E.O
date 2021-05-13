namespace Ma2013.A.E.O.Classes.ResultElements.TP.WardDayBedAvailabilityDeviations
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δMinusResultElement : IδMinusResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δMinusResultElement(
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