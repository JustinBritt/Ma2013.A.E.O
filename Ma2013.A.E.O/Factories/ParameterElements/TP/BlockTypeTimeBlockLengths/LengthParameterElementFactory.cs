namespace Ma2013.A.E.O.Factories.ParameterElements.TP.BlockTypeTimeBlockLengths
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.BlockTypeTimeBlockLengths;

    internal sealed class LengthParameterElementFactory : ILengthParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LengthParameterElementFactory()
        {
        }

        public ILengthParameterElement Create(
            IkIndexElement kIndexElement,
            Duration value)
        {
            ILengthParameterElement parameterElement = null;

            try
            {
                parameterElement = new LengthParameterElement(
                    kIndexElement,
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