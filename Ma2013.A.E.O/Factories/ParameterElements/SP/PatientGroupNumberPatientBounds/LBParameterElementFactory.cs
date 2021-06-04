namespace Ma2013.A.E.O.Factories.ParameterElements.SP.PatientGroupNumberPatientBounds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupNumberPatientBounds;

    internal sealed class LBParameterElementFactory : ILBParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LBParameterElementFactory()
        {
        }

        public ILBParameterElement Create(
            IpIndexElement pIndexElement,
            PositiveInt value)
        {
            ILBParameterElement parameterElement = null;

            try
            {
                parameterElement = new LBParameterElement(
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