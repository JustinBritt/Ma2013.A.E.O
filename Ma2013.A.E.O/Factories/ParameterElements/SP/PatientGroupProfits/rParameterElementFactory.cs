namespace Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupProfits
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupProfits;

    internal sealed class rParameterElementFactory : IrParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rParameterElementFactory()
        {
        }

        public IrParameterElement Create(
            IpIndexElement pIndexElement,
            Money value)
        {
            IrParameterElement parameterElement = null;

            try
            {
                parameterElement = new rParameterElement(
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