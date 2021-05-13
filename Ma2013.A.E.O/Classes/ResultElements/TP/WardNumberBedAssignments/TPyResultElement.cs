namespace Ma2013.A.E.O.Classes.ResultElements.TP.WardNumberBedAssignments
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;

    internal sealed class TPyResultElement : ITPyResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPyResultElement(
            IwIndexElement wIndexElement,
            int value)
        {
            this.wIndexElement = wIndexElement;

            this.Value = value;
        }

        public IwIndexElement wIndexElement { get; }

        public int Value { get; }
    }
}