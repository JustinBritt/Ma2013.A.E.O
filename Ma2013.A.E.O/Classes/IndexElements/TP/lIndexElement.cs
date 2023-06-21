namespace Ma2013.A.E.O.Classes.IndexElements.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class lIndexElement : IlIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public INullableValue<int> Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IlIndexElement other)
        {
            return this.Value.Value.Value.CompareTo(
                other.Value.Value.Value);
        }
    }
}