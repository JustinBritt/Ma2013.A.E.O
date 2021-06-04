namespace Ma2013.A.E.O.Factories.Results.TP.UnutilizedTime
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.Interfaces.Results.TP.UnutilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UnutilizedTime;

    internal sealed class UnutilizedTimeFactory : IUnutilizedTimeFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UnutilizedTimeFactory()
        {
        }

        public IUnutilizedTime Create(
            decimal value)
        {
            IUnutilizedTime result = null;

            try
            {
                result = new UnutilizedTime(
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