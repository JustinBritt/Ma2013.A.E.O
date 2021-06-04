namespace Ma2013.A.E.O.Factories.Results.TP.NumberPatients
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.NumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.NumberPatients;

    internal sealed class NumberPatientsFactory : INumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberPatientsFactory()
        {
        }

        public INumberPatients Create(
            int value)
        {
            INumberPatients result = null;

            try
            {
                result = new NumberPatients(
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