namespace Ma2013.A.E.O.Classes.Results.TP.TotalTime
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Results.TP.TotalTime;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TotalTime : ITotalTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TotalTime(
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