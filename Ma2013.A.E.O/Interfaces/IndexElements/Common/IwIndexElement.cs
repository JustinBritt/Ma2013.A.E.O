namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface IwIndexElement
    {
        /// <summary>
        /// Gets the ward.
        /// </summary>
        Organization Value { get; }
    }
}