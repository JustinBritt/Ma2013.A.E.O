namespace Ma2013.A.E.O.Factories.ParameterElements.TP.PatientGroupThroughputs
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupThroughputs;

    internal sealed class THRParameterElementFactory : ITHRParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public THRParameterElementFactory()
        {
        }

        public ITHRParameterElement Create(
            IpIndexElement pIndexElement,
            PositiveInt value)
        {
            ITHRParameterElement parameterElement = null;

            try
            {
                parameterElement = new THRParameterElement(
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