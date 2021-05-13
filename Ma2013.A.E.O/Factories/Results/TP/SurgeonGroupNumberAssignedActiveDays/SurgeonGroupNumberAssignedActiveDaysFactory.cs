namespace Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysFactory : ISurgeonGroupNumberAssignedActiveDaysFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysFactory()
        {
        }

        public ISurgeonGroupNumberAssignedActiveDays Create(
            ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> value)
        {
            ISurgeonGroupNumberAssignedActiveDays result = null;

            try
            {
                result = new SurgeonGroupNumberAssignedActiveDays(
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