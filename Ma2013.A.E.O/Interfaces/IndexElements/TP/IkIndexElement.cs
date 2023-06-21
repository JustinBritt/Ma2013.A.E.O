namespace Ma2013.A.E.O.Interfaces.IndexElements.TP
{
    using Hl7.Fhir.Model;

    public interface IkIndexElement
    {
        /// <summary>
        /// Gets the block type.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}