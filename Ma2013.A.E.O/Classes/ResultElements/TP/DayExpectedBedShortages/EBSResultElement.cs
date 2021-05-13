namespace Ma2013.A.E.O.Classes.ResultElements.TP.DayExpectedBedShortages
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;

    internal sealed class EBSResultElement : IEBSResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSResultElement(
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