namespace Ma2013.A.E.O.Interfaces.Indices.Common
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface Is
    {
        ImmutableList<IsIndexElement> Value { get; }

        IsIndexElement GetElementAt(
            Organization value);
    }
}