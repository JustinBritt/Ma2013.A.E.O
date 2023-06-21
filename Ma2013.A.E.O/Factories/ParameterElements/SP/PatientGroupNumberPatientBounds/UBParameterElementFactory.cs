namespace Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupNumberPatientBounds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupNumberPatientBounds;

    internal sealed class UBParameterElementFactory : IUBParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public UBParameterElementFactory()
        {
        }

        public IUBParameterElement Create(
            IpIndexElement pIndexElement,
            INullableValue<int> value)
        {
            IUBParameterElement parameterElement = null;

            try
            {
                parameterElement = new UBParameterElement(
                    pIndexElement,
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