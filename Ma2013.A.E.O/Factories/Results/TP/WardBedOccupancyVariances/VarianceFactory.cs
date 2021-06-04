namespace Ma2013.A.E.O.Factories.Results.TP.WardBedOccupancyVariances
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances;

    internal sealed class VarianceFactory : IVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceFactory()
        {
        }

        public IVariance Create(
            ImmutableList<IVarianceResultElement> value)
        {
            IVariance result = null;

            try
            {
                result = new Variance(
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