namespace Ma2013.A.E.O.Factories.Parameters.Common.PatientGroupSurgeryDurations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.PatientGroupSurgeryDurations;

    internal sealed class durFactory : IdurFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public durFactory()
        {
        }

        public Idur Create(
            ImmutableList<IdurParameterElement> value)
        {
            Idur parameter = null;

            try
            {
                parameter = new dur(
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