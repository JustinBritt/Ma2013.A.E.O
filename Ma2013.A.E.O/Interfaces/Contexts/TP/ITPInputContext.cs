namespace Ma2013.A.E.O.Interfaces.Contexts.TP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;
    using NGenerics.DataStructures.Trees;

    public interface ITPInputContext
    {
        RedBlackTree<INullableValue<int>, FhirDateTime> ActiveDays { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> Days { get; }

        ImmutableSortedSet<INullableValue<int>> BlockTypes { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        ImmutableSortedSet<INullableValue<int>> PatientGroups { get; }

        Bundle OperatingRooms { get; }

        Bundle SurgeonGroups { get; }

        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        INullableValue<int> NumberBeds { get; }

        RedBlackTree<INullableValue<int>, Duration> PatientGroupSurgeryDurations { get; }

        RedBlackTree<INullableValue<int>, Duration> BlockTypeTimeBlockLengths { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<Location, Duration>> DayOperatingRoomOperatingCapacities { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonGroupSubsetPatientGroups { get; }

        RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> WardSubsetPatientGroups { get; }

        RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> PatientGroupDayLengthOfStayProbabilities { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> PatientGroupThroughputs { get; }

        RedBlackTree<Organization, INullableValue<decimal>> Wardα { get; }

        RedBlackTree<Organization, INullableValue<decimal>> Wardβ { get; }

        RedBlackTree<Organization, INullableValue<decimal>> Wardγ { get; }
    }
}