﻿namespace Ma2013.A.E.O.Classes.Indices.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            ImmutableList<IrIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IrIndexElement> Value { get; }

        public IrIndexElement GetElementAt(
            Location value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}