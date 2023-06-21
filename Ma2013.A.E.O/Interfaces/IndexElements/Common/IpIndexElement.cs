namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using System;

    using Hl7.Fhir.Model;

    public interface IpIndexElement : IComparable<IpIndexElement>
    {
        /// <summary>
        /// Gets the patient group.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}