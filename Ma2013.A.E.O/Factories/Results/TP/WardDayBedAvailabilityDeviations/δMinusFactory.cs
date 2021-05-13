namespace Ma2013.A.E.O.Factories.Results.TP.WardDayBedAvailabilityDeviations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δMinusFactory : IδMinusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δMinusFactory()
        {
        }

        public IδMinus Create(
            ImmutableList<IδMinusResultElement> value)
        {
            IδMinus result = null;

            try
            {
                result = new δMinus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}