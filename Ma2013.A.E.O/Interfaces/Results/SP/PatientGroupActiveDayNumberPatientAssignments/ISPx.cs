namespace Ma2013.A.E.O.Interfaces.Results.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISPx
    {
        ImmutableList<ISPxResultElement> Value { get; }

        ImmutableList<Tuple<INullableValue<int>, FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}