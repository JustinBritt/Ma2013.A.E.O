namespace Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupDaySubsetActiveDays
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupDaySubsetActiveDays;

    internal sealed class AParameterElementFactory : IAParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AParameterElementFactory()
        {
        }

        public IAParameterElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            ImmutableList<IdIndexElement> value)
        {
            IAParameterElement parameterElement = null;

            try
            {
                parameterElement = new AParameterElement(
                    pIndexElement,
                    aIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}