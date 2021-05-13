namespace Ma2013.A.E.O.Factories.IndexElements.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.Common;

    internal sealed class aIndexElementFactory : IaIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public aIndexElementFactory()
        {
        }

        public IaIndexElement Create(
            int key,
            FhirDateTime value)
        {
            IaIndexElement indexElement = null;

            try
            {
                indexElement = new aIndexElement(
                    key,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return indexElement;
        }
    }
}