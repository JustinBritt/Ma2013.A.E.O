namespace Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysResultElement : ISurgeonGroupNumberAssignedActiveDaysResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysResultElement(
            IsIndexElement sIndexElement,
            int value)
        {
            this.sIndexElement = sIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public int Value { get; }
    }
}