namespace Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupNumberPatients
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsResultElement : ISurgeonGroupNumberPatientsResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsResultElement(
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