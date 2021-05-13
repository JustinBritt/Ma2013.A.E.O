namespace Ma2013.A.E.O.Interfaces.Results.SP.WardNumberBedAssignments
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISPy
    {
        ImmutableList<ISPyResultElement> Value { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}