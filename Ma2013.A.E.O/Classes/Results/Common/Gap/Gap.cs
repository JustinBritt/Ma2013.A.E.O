namespace Ma2013.A.E.O.Classes.Results.Common.Gap
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Results.Common.Gap;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class Gap : IGap
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Gap(
            decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; }

        public INullableValue<decimal> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return nullableValueFactory.Create<decimal>(
                this.Value);
        }
    }
}