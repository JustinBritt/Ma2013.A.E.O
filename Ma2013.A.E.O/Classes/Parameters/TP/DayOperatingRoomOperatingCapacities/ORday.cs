namespace Ma2013.A.E.O.Classes.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;

    internal sealed class ORday : IORday
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ORday(
            ImmutableList<IORdayParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IORdayParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.Value
                .Where(x => x.aIndexElement == aIndexElement && x.rIndexElement == rIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}