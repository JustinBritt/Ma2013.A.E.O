namespace Ma2013.A.E.O.Factories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;

    internal sealed class probParameterElementFactory : IprobParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public probParameterElementFactory()
        {
        }

        public IprobParameterElement Create(
            IpIndexElement pIndexElement,
            IlIndexElement lIndexElement,
            FhirDecimal value)
        {
            IprobParameterElement parameterElement = null;

            try
            {
                parameterElement = new probParameterElement(
                    pIndexElement,
                    lIndexElement,
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