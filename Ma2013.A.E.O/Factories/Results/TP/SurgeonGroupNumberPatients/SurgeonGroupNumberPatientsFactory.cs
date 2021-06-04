namespace Ma2013.A.E.O.Factories.Results.TP.SurgeonGroupNumberPatients
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsFactory : ISurgeonGroupNumberPatientsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsFactory()
        {
        }

        public ISurgeonGroupNumberPatients Create(
            ImmutableList<ISurgeonGroupNumberPatientsResultElement> value)
        {
            ISurgeonGroupNumberPatients result = null;

            try
            {
                result = new SurgeonGroupNumberPatients(
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