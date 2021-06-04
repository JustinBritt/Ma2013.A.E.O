namespace Ma2013.A.E.O.Factories.Parameters.SP.PatientGroupProfits
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupProfits;

    internal sealed class rFactory : IrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rFactory()
        {
        }

        public Ir Create(
            ImmutableList<IrParameterElement> value)
        {
            Ir parameter = null;

            try
            {
                parameter = new r(
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