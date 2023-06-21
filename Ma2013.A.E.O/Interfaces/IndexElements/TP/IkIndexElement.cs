namespace Ma2013.A.E.O.Interfaces.IndexElements.TP
{
    using System;

    using Hl7.Fhir.Model;

    public interface IkIndexElement : IComparable<IkIndexElement>
    {
        /// <summary>
        /// Gets the block type.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}