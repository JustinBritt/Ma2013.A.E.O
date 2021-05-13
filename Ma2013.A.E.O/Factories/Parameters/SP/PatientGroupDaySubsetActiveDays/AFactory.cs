namespace Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupDaySubsetActiveDays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupDaySubsetActiveDays;

    internal sealed class AFactory : IAFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AFactory()
        {
        }

        public IA Create(
            ImmutableList<IAParameterElement> value)
        {
            IA parameter = null;

            try
            {
                parameter = new A(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}