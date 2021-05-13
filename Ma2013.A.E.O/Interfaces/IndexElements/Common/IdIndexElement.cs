namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface IdIndexElement
    {
        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        FhirDateTime Value { get; }
    }
}