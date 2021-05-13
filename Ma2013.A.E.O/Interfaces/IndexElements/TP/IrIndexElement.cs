namespace Ma2013.A.E.O.Interfaces.IndexElements.TP
{
    using Hl7.Fhir.Model;

    public interface IrIndexElement
    {
        /// <summary>
        /// Gets the operating room.
        /// </summary>
        Location Value { get; }
    }
}