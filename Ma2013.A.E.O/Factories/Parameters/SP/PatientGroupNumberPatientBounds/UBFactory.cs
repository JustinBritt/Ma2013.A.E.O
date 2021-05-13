namespace Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupNumberPatientBounds
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupNumberPatientBounds;

    internal sealed class UBFactory : IUBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UBFactory()
        {
        }

        public IUB Create(
            ImmutableList<IUBParameterElement> value)
        {
            IUB parameter = null;

            try
            {
                parameter = new UB(
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