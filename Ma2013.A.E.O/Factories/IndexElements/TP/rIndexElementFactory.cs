namespace Ma2013.A.E.O.Factories.IndexElements.TP
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.TP;

    internal sealed class rIndexElementFactory : IrIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rIndexElementFactory()
        {
        }

        public IrIndexElement Create(
            Location value)
        {
            IrIndexElement indexElement = null;

            try
            {
                indexElement = new rIndexElement(
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