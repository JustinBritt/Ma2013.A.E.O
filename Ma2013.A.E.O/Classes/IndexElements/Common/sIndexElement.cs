﻿namespace Ma2013.A.E.O.Classes.IndexElements.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class sIndexElement : IsIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the surgeon group.
        /// </summary>
        public Organization Value { get; }
    }
}