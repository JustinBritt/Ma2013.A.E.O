namespace Ma2013.A.E.O.Factories.ParameterElements.TP.WardObjectiveFunctionWeights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.WardObjectiveFunctionWeights;

    internal sealed class βParameterElementFactory : IβParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βParameterElementFactory()
        {
        }

        public IβParameterElement Create(
            IwIndexElement wIndexElement,
            FhirDecimal value)
        {
            IβParameterElement parameterElement = null;

            try
            {
                parameterElement = new βParameterElement(
                    wIndexElement,
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