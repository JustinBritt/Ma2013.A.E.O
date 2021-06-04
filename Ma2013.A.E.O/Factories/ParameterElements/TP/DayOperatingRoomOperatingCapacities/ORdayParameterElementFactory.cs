namespace Ma2013.A.E.O.Factories.ParameterElements.TP.DayOperatingRoomOperatingCapacities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.DayOperatingRoomOperatingCapacities;

    internal sealed class ORdayParameterElementFactory : IORdayParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ORdayParameterElementFactory()
        {
        }

        public IORdayParameterElement Create(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            Duration value)
        {
            IORdayParameterElement parameterElement = null;

            try
            {
                parameterElement = new ORdayParameterElement(
                    aIndexElement,
                    rIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}