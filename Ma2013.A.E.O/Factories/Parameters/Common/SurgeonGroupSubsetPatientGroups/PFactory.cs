namespace Ma2013.A.E.O.Factories.Parameters.Common.SurgeonGroupSubsetPatientGroups
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups;

    internal sealed class PFactory : IPFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PFactory()
        {
        }

        public IP Create(
            ImmutableList<IPParameterElement> value)
        {
            IP parameter = null;

            try
            {
                parameter = new P(
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