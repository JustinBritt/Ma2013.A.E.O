namespace Ma2013.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class aIndexElement : IaIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public aIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <inheritdoc/>
        public int Key { get; }

        /// <inheritdoc/>
        public FhirDateTime Value { get; }
    }
}