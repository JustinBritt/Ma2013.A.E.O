namespace Ma2013.A.E.O.InterfacesFactories.Contexts.TP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.Contexts.TP;

    public interface ITPInputContextFactory
    {
        ITPInputContext Create(
            RedBlackTree<INullableValue<int>, FhirDateTime> activeDays,
            RedBlackTree<INullableValue<int>, FhirDateTime> days,
            ImmutableSortedSet<INullableValue<int>> blockTypes,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle operatingRooms,
            Bundle surgeonGroups,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> wards,
            INullableValue<int> numberBeds,
            RedBlackTree<INullableValue<int>, Duration> patientGroupSurgeryDurations,
            RedBlackTree<INullableValue<int>, Duration> blockTypeTimeBlockLengths,
            RedBlackTree<FhirDateTime, RedBlackTree<Location, Duration>> dayOperatingRoomOperatingCapacities,
            RedBlackTree<Organization, INullableValue<int>> surgeonGroupSubsetPatientGroups,
            RedBlackTree<Organization, INullableValue<int>> wardSubsetPatientGroups,
            ImmutableList<Tuple<INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> patientGroupDayLengthOfStayProbabilities,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupThroughputs,
            RedBlackTree<Organization, INullableValue<decimal>> wardα,
            RedBlackTree<Organization, INullableValue<decimal>> wardβ,
            RedBlackTree<Organization, INullableValue<decimal>> wardγ);
    }
}