namespace Ma2013.A.E.O.Factories.Parameters.TP.PatientGroupThroughputs
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupThroughputs;

    internal sealed class THRFactory : ITHRFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public THRFactory()
        {
        }

        public ITHR Create(
            ImmutableList<ITHRParameterElement> value)
        {
            ITHR parameter = null;

            try
            {
                parameter = new THR(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}