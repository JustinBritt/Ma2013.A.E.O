namespace Ma2013.A.E.O.Interfaces.Indices.TP
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface Ir
    {
        ImmutableList<IrIndexElement> Value { get; }

        IrIndexElement GetElementAt(
            Location value);
    }
}