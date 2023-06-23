﻿namespace Ma2013.A.E.O.InterfacesFactories.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.Contexts.TP;

    public interface ITPInputContextFactory
    {
        ITPInputContext Create(
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> activeDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> days,
            ImmutableSortedSet<INullableValue<int>> blockTypes,
            ImmutableList<INullableValue<int>> lengthOfStayDays,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle operatingRooms,
            Bundle surgeonGroups,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> wards,
            INullableValue<int> numberBeds,
            RedBlackTree<INullableValue<int>, Duration> patientGroupSurgeryDurations,
            ImmutableList<KeyValuePair<INullableValue<int>, Duration>> blockTypeTimeBlockLengths,
            ImmutableList<Tuple<FhirDateTime, Location, Duration>> dayOperatingRoomOperatingCapacities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> wardSubsetPatientGroups,
            ImmutableList<Tuple<INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> patientGroupDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> patientGroupThroughputs,
            RedBlackTree<Organization, INullableValue<decimal>> wardα,
            RedBlackTree<Organization, INullableValue<decimal>> wardβ,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> wardγ);
    }
}