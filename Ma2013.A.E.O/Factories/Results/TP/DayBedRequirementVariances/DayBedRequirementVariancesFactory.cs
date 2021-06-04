namespace Ma2013.A.E.O.Factories.Results.TP.DayBedRequirementVariances
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayBedRequirementVariances;

    internal sealed class DayBedRequirementVariancesFactory : IDayBedRequirementVariancesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariancesFactory()
        {
        }

        public IDayBedRequirementVariances Create(
            ImmutableList<IDayBedRequirementVariancesResultElement> value)
        {
            IDayBedRequirementVariances result = null;

            try
            {
                result = new DayBedRequirementVariances(
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