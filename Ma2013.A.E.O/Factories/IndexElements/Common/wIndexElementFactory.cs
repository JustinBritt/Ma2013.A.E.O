namespace Ma2013.A.E.O.Factories.IndexElements.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.Common;

    internal sealed class wIndexElementFactory : IwIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wIndexElementFactory()
        {
        }

        public IwIndexElement Create(
            Organization value)
        {
            IwIndexElement indexElement = null;

            try
            {
                indexElement = new wIndexElement(
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