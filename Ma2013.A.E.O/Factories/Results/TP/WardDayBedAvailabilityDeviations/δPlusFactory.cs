namespace Ma2013.A.E.O.Factories.Results.TP.WardDayBedAvailabilityDeviations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δPlusFactory : IδPlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlusFactory()
        {
        }

        public IδPlus Create(
            ImmutableList<IδPlusResultElement> value)
        {
            IδPlus result = null;

            try
            {
                result = new δPlus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}