namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface IsIndexElement
    {
        /// <summary>
        /// Gets the surgeon group.
        /// </summary>
        Organization Value { get; }
    }
}