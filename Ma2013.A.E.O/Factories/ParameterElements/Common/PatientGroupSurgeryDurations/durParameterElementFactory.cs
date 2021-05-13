namespace Ma2013.A.E.O.Factories.ParameterElements.Common.PatientGroupSurgeryDurations
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.PatientGroupSurgeryDurations;

    internal sealed class durParameterElementFactory : IdurParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public durParameterElementFactory()
        {
        }

        public IdurParameterElement Create(
            IpIndexElement pIndexElement,
            Duration value)
        {
            IdurParameterElement parameterElement = null;

            try
            {
                parameterElement = new durParameterElement(
                    pIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameterElement;
        }
    }
}