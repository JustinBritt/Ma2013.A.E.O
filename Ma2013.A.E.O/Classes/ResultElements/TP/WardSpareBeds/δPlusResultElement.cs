namespace Ma2013.A.E.O.Classes.ResultElements.TP.WardSpareBeds
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;

    internal sealed class δPlusResultElement : IδPlusResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlusResultElement(
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