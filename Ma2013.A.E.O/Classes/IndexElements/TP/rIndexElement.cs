namespace Ma2013.A.E.O.Classes.IndexElements.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    internal sealed class rIndexElement : IrIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rIndexElement(
            Location value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Location Value { get; }
    }
}