namespace Ma2013.A.E.O.Factories.Results.TP.WardNumberAssignedActiveDays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedActiveDays;

    internal sealed class WardNumberAssignedActiveDaysFactory : IWardNumberAssignedActiveDaysFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedActiveDaysFactory()
        {
        }

        public IWardNumberAssignedActiveDays Create(
            ImmutableList<IWardNumberAssignedActiveDaysResultElement> value)
        {
            IWardNumberAssignedActiveDays result = null;

            try
            {
                result = new WardNumberAssignedActiveDays(
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