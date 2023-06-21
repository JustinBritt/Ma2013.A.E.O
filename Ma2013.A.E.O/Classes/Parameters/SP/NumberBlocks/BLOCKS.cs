namespace Ma2013.A.E.O.Classes.Parameters.SP.NumberBlocks
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;

    internal sealed class BLOCKS : IBLOCKS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BLOCKS(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        public INullableValue<int> Value { get; }
    }
}