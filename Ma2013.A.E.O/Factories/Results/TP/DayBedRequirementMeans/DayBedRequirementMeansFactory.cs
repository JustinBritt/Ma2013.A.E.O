namespace Ma2013.A.E.O.Factories.Results.TP.DayBedRequirementMeans
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementMeans;

    internal sealed class DayBedRequirementMeansFactory : IDayBedRequirementMeansFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeansFactory()
        {
        }

        public IDayBedRequirementMeans Create(
            ImmutableList<IDayBedRequirementMeansResultElement> value)
        {
            IDayBedRequirementMeans result = null;

            try
            {
                result = new DayBedRequirementMeans(
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