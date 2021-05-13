namespace Ma2013.A.E.O.Factories.Parameters.SP.NumberBlocks
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.SP.NumberBlocks;

    internal sealed class BLOCKSFactory : IBLOCKSFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BLOCKSFactory()
        {
        }

        public IBLOCKS Create(
            PositiveInt value)
        {
            IBLOCKS parameter = null;

            try
            {
                parameter = new BLOCKS(
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