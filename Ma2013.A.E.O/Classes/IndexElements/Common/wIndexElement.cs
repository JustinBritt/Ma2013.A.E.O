namespace Ma2013.A.E.O.Classes.IndexElements.Common
{
    using System;

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

        /// <inheritdoc/>
        public Organization Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IwIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}