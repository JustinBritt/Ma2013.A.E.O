namespace Ma2013.A.E.O.Classes.ParameterElements.TP.DayOperatingRoomOperatingCapacities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;

    internal sealed class ORdayParameterElement : IORdayParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ORdayParameterElement(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            Duration value)
        {
            this.aIndexElement = aIndexElement;

            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public IaIndexElement aIndexElement { get; }

        public IrIndexElement rIndexElement { get; }

        public Duration Value { get; }
    }
}