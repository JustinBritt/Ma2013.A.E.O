namespace Ma2013.A.E.O.Interfaces.Results.SP.WardNumberBedAssignments
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISPy
    {
        ImmutableList<ISPyResultElement> Value { get; }

        RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}