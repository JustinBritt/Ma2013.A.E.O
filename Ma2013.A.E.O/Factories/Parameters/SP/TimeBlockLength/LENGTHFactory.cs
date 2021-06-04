namespace Ma2013.A.E.O.Factories.Parameters.SP.TimeBlockLength
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.TimeBlockLength;

    internal sealed class LENGTHFactory : ILENGTHFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LENGTHFactory()
        {
        }

        public ILENGTH Create(
            Duration value)
        {
            ILENGTH parameter = null;

            try
            {
                parameter = new LENGTH(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}