namespace Ma2013.A.E.O.Interfaces.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ISPInputContext
    {
        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> ActiveDays { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> Days { get; }

        ImmutableList<INullableValue<int>> PatientGroups { get; }

        Bundle SurgeonGroups { get; }

        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        ImmutableList<Tuple<INullableValue<int>, FhirDateTime, FhirDateTime>> PatientGroupDaySubsetActiveDays { get; }

        INullableValue<int> NumberBeds { get; }

        INullableValue<int> NumberBlocks { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, Duration>> PatientGroupSurgeryDurations { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupNumberPatientLowerBounds { get; }

        Duration TimeBlockLength { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonGroupSubsetPatientGroups { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardSubsetPatientGroups { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, Money>> PatientGroupProfits { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupThroughputs { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupNumberPatientUpperBounds { get; }
    }
}