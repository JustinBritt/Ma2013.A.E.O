namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using System;

    using Hl7.Fhir.Model;
    
    public interface IwIndexElement : IComparable<IwIndexElement>
    {
        /// <summary>
        /// Gets the ward.
        /// </summary>
        Organization Value { get; }
    }
}