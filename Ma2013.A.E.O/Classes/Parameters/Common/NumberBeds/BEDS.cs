namespace Ma2013.A.E.O.Classes.Parameters.Common.NumberBeds
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;

    internal sealed class BEDS : IBEDS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BEDS(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        public INullableValue<int> Value { get; }
    }
}