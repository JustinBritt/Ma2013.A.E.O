namespace Ma2013.A.E.O.Factories.Results.TP.UtilizedTime
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UtilizedTime;

    internal sealed class UtilizedTimeFactory : IUtilizedTimeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UtilizedTimeFactory()
        {
        }

        public IUtilizedTime Create(
            decimal value)
        {
            IUtilizedTime result = null;

            try
            {
                result = new UtilizedTime(
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