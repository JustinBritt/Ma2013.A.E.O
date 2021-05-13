namespace Ma2013.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class wIndexElement : IwIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the ward.
        /// </summary>
        public Organization Value { get; }
    }
}