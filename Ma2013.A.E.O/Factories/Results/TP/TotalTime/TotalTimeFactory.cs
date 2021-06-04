namespace Ma2013.A.E.O.Factories.Results.TP.TotalTime
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.TotalTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.TotalTime;

    internal sealed class TotalTimeFactory : ITotalTimeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalTimeFactory()
        {
        }

        public ITotalTime Create(
            decimal value)
        {
            ITotalTime result = null;

            try
            {
                result = new TotalTime(
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