namespace Ma2013.A.E.O.Factories.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.DayOperatingRoomOperatingCapacities;

    internal sealed class ORdayFactory : IORdayFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ORdayFactory()
        {
        }

        public IORday Create(
            ImmutableList<IORdayParameterElement> value)
        {
            IORday parameter = null;

            try
            {
                parameter = new ORday(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}