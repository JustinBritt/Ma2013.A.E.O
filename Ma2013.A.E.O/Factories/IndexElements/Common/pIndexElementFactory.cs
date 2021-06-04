namespace Ma2013.A.E.O.Factories.IndexElements.Common
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.Common;

    internal sealed class pIndexElementFactory : IpIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pIndexElementFactory()
        {
        }

        public IpIndexElement Create(
            PositiveInt value)
        {
            IpIndexElement indexElement = null;

            try
            {
                indexElement = new pIndexElement(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return indexElement;
        }
    }
}