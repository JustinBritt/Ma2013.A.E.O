namespace Ma2013.A.E.O.Factories.Results.TP.Underutilization
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.Underutilization;
    using Ma2013.A.E.O.Interfaces.Results.TP.Underutilization;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.Underutilization;

    internal sealed class UnderutilizationFactory : IUnderutilizationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UnderutilizationFactory()
        {
        }

        public IUnderutilization Create(
            decimal value)
        {
            IUnderutilization result = null;

            try
            {
                result = new Underutilization(
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