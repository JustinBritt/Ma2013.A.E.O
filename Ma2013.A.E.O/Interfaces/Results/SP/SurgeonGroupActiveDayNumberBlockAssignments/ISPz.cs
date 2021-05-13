namespace Ma2013.A.E.O.Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISPz
    {
        ImmutableList<ISPzResultElement> Value { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}