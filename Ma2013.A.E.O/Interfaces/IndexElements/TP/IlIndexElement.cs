namespace Ma2013.A.E.O.Interfaces.IndexElements.TP
{
    using System;

    using Hl7.Fhir.Model;

    public interface IlIndexElement : IComparable<IlIndexElement>
    {
        /// <summary>
        /// Gets the day.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}