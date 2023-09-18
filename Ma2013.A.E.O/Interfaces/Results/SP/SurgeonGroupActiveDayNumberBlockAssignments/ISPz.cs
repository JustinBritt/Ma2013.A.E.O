namespace Ma2013.A.E.O.Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISPz
    {
        ImmutableList<ISPzResultElement> Value { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Is s);
    }
}