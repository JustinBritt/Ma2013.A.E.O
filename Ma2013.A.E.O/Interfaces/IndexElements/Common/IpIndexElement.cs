namespace Ma2013.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface IpIndexElement
    {
        /// <summary>
        /// Gets the patient group.
        /// </summary>
        PositiveInt Value { get; }
    }
}