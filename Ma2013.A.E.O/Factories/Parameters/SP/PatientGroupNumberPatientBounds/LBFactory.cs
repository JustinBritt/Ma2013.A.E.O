namespace Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupNumberPatientBounds
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupNumberPatientBounds;

    internal sealed class LBFactory : ILBFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LBFactory()
        {
        }

        public ILB Create(
            ImmutableList<ILBParameterElement> value)
        {
            ILB parameter = null;

            try
            {
                parameter = new LB(
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