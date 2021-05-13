namespace Ma2013.A.E.O.Classes.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class SPzResultElement : ISPzResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPzResultElement(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            int value)
        {
            this.sIndexElement = sIndexElement;

            this.aIndexElement = aIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IaIndexElement aIndexElement { get; }

        public int Value { get; }
    }
}