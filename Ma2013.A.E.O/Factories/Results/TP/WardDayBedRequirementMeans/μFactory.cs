namespace Ma2013.A.E.O.Factories.Results.TP.WardDayBedRequirementMeans
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementMeans;

    internal sealed class μFactory : IμFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μFactory()
        {
        }

        public Iμ Create(
            ImmutableList<IμResultElement> value)
        {
            Iμ result = null;

            try
            {
                result = new μ(
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