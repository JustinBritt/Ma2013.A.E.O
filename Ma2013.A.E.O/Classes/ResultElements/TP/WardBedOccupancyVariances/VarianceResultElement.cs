namespace Ma2013.A.E.O.Classes.ResultElements.TP.WardBedOccupancyVariances
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances;

    internal sealed class VarianceResultElement : IVarianceResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceResultElement(
            IwIndexElement wIndexElement,
            decimal value)
        {
            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public decimal Value { get; }
    }
}