namespace Ma2013.A.E.O.InterfacesFactories.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Contexts.SP;

    public interface ISPInputContextFactory
    {
        ISPInputContext Create(
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> activeDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> days,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle surgeonGroups,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> wards,
            ImmutableList<Tuple<INullableValue<int>, FhirDateTime, FhirDateTime>> patientGroupDaySubsetActiveDays,
            INullableValue<int> numberBeds,
            INullableValue<int> numberBlocks,
            ImmutableList<KeyValuePair<INullableValue<int>, Duration>> patientGroupSurgeryDurations,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> patientGroupNumberPatientLowerBounds,
            Duration timeBlockLength,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> wardSubsetPatientGroups,
            ImmutableList<KeyValuePair<INullableValue<int>, Money>> patientGroupProfits,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> patientGroupThroughputs,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> patientGroupNumberPatientUpperBounds);
    }
}