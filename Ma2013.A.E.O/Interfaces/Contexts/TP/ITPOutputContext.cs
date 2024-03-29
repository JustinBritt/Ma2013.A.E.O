﻿namespace Ma2013.A.E.O.Interfaces.Contexts.TP
{
    using System;

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

        RedBlackTree<INullableValue<int>, RedBlackTree<FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        RedBlackTree<Organization, INullableValue<int>> WardNumberBedAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>>> SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityMinusDeviations { get; }

        RedBlackTree<Organization, INullableValue<decimal>> WardSpareBeds { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityPlusDeviations { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementMeans { get; }

        RedBlackTree<Organization, INullableValue<decimal>> WardBedOccupancyVariances { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementVariances { get; }
    }
}