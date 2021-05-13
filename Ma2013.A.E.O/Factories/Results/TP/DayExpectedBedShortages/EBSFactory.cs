namespace Ma2013.A.E.O.Factories.Results.TP.DayExpectedBedShortages
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.DayExpectedBedShortages;

    internal sealed class EBSFactory : IEBSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EBSFactory()
        {
        }

        public IEBS Create(
            ImmutableList<IEBSResultElement> value)
        {
            IEBS result = null;

            try
            {
                result = new EBS(
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