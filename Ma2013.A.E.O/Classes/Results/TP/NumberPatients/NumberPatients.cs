namespace Ma2013.A.E.O.Classes.Results.TP.NumberPatients
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Results.TP.NumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class NumberPatients : INumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberPatients(
            int value)
        {
            this.Value = value;
        }

        public int Value { get; }

        public INullableValue<int> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return nullableValueFactory.Create<int>(
                this.Value);
        }
    }
}