namespace Ma2013.A.E.O.Interfaces.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ITPOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> DayBedRequirementMeans { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> DayBedRequirementVariances { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<decimal>>> DayExpectedBedShortages { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<int> NumberPatients { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonGroupNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonGroupNumberAssignedActiveDays { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> SurgeonGroupNumberPatients { get; }

        INullableValue<decimal> TotalExpectedBedShortage { get; }

        INullableValue<decimal> TotalTime { get; }

        INullableValue<decimal> Underutilization { get; }

        INullableValue<decimal> UnutilizedTime { get; }

        INullableValue<decimal> UtilizedTime { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> WardNumberAssignedOperatingRooms { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>>> WardNumberAssignedActiveDays { get; }

        ImmutableList<Tuple<INullableValue<int>, FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardNumberBedAssignments { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, Location, INullableValue<int>, INullableValue<bool>>> SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityMinusDeviations { get; }

        ImmutableList<Tuple<Organization, INullableValue<decimal>>> WardSpareBeds { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedAvailabilityPlusDeviations { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementMeans { get; }

        ImmutableList<Tuple<Organization, INullableValue<decimal>>> WardBedOccupancyVariances { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<decimal>>> WardDayBedRequirementVariances { get; }
    }
}