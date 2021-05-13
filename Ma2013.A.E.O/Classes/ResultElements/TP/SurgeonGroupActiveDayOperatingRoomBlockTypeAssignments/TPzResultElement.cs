namespace Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    internal sealed class TPzResultElement : ITPzResultElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPzResultElement(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement,
            bool value)
        {
            this.sIndexElement = sIndexElement;

            this.aIndexElement = aIndexElement;

            this.rIndexElement = rIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public IsIndexElement sIndexElement { get; }

        public IaIndexElement aIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public IkIndexElement kIndexElement { get; }

        public bool Value { get; }
    }
}