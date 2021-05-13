namespace Ma2013.A.E.O.Interfaces.Indices.TP
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface Ik
    {
        ImmutableList<IkIndexElement> Value { get; }

        IkIndexElement GetElementAt(
            PositiveInt value);
    }
}