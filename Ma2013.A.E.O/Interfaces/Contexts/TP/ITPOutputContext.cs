namespace Ma2013.A.E.O.Interfaces.Contexts.TP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface ITPOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedRequirementMeans { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayBedRequirementVariances { get; }

        RedBlackTree<FhirDateTime, INullableValue<decimal>> DayExpectedBedShortages { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<int> NumberPatients { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonGroupNumberAssignedOperatingRooms { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonGroupNumberAssignedActiveDays { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonGroupNumberPatients { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        INullableValue<decimal> TotalTime { get; }

        INullableValue<decimal> Underutilization { get; }

        INullableValue<decimal> UnutilizedTime { get; }

        INullableValue<decimal> UtilizedTime { get; }

        RedBlackTree<Organization, INullableValue<int>> WardNumberAssignedOperatingRooms { get; }

        RedBlackTree<Organization, INullableValue<int>> WardNumberAssignedActiveDays { get; }

        ImmutableList<Tuple<INullableValue<int>, FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        RedBlackTree<Organization, INullableValue<int>> WardNumberBedAssignments { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, Location, INullableValue<int>, INullableValue<bool>>> SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityMinusDeviations { get; }

        RedBlackTree<Organization, INullableValue<decimal>> WardSpareBeds { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityPlusDeviations { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementMeans { get; }

        ImmutableList<Tuple<Organization, INullableValue<decimal>>> WardBedOccupancyVariances { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementVariances { get; }
    }
}