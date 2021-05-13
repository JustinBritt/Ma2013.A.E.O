namespace Ma2013.A.E.O.Factories.Parameters.Common.NumberBeds
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.NumberBeds;

    internal sealed class BEDSFactory : IBEDSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BEDSFactory()
        {
        }

        public IBEDS Create(
            PositiveInt value)
        {
            IBEDS parameter = null;

            try
            {
                parameter = new BEDS(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}