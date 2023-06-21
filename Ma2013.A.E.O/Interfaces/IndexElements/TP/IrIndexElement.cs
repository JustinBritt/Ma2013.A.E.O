namespace Ma2013.A.E.O.Interfaces.IndexElements.TP
{
    using System;

    using Hl7.Fhir.Model;

    public interface IrIndexElement : IComparable<IrIndexElement>
    {
        /// <summary>
        /// Gets the operating room.
        /// </summary>
        Location Value { get; }
    }
}