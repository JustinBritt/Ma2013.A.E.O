namespace Ma2013.A.E.O.Classes.ResultElements.SP.WardNumberBedAssignments
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;

    internal sealed class SPyResultElement : ISPyResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPyResultElement(
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