﻿namespace Ma2013.A.E.O.Classes.Contexts.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.Contexts.TP;

    public sealed class TPInputContext : ITPInputContext
    { 
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPInputContext(
            RedBlackTree<INullableValue<int>, FhirDateTime> activeDays,
            RedBlackTree<INullableValue<int>, FhirDateTime> days,
            ImmutableSortedSet<INullableValue<int>> blockTypes,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle operatingRooms,
            Bundle surgeonGroups,
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> wards,
            INullableValue<int> numberBeds,
            RedBlackTree<INullableValue<int>, Duration> patientGroupSurgeryDurations,
            RedBlackTree<INullableValue<int>, Duration> blockTypeTimeBlockLengths,
            RedBlackTree<FhirDateTime, RedBlackTree<Location, Duration>> dayOperatingRoomOperatingCapacities,
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> wardSubsetPatientGroups,
            RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> patientGroupDayLengthOfStayProbabilities,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupThroughputs,
            RedBlackTree<Organization, INullableValue<decimal>> wardα,
            RedBlackTree<Organization, INullableValue<decimal>> wardβ,
            RedBlackTree<Organization, INullableValue<decimal>> wardγ)
        {
            this.ActiveDays = activeDays;

            this.Days = days;

            this.BlockTypes = blockTypes;

            this.LengthOfStayDays = lengthOfStayDays;

            this.PatientGroups = patientGroups;

            this.OperatingRooms = operatingRooms;

            this.SurgeonGroups = surgeonGroups;

            this.Wards = wards;

            this.NumberBeds = numberBeds;

            this.PatientGroupSurgeryDurations = patientGroupSurgeryDurations;

            this.BlockTypeTimeBlockLengths = blockTypeTimeBlockLengths;

            this.DayOperatingRoomOperatingCapacities = dayOperatingRoomOperatingCapacities;

            this.SurgeonGroupSubsetPatientGroups = surgeonGroupSubsetPatientGroups;

            this.WardSubsetPatientGroups = wardSubsetPatientGroups;

            this.PatientGroupDayLengthOfStayProbabilities = patientGroupDayLengthOfStayProbabilities;

            this.PatientGroupThroughputs = patientGroupThroughputs;

            this.Wardα = wardα;

            this.Wardβ = wardβ;

            this.Wardγ = wardγ;
        }

        public RedBlackTree<INullableValue<int>, FhirDateTime> ActiveDays { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> Days { get; }

        public ImmutableSortedSet<INullableValue<int>> BlockTypes { get; }

        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        public ImmutableSortedSet<INullableValue<int>> PatientGroups { get; }

        public Bundle OperatingRooms { get; }

        public Bundle SurgeonGroups { get; }

        public RedBlackTree<Organization, ImmutableSortedSet<Organization>> Wards { get; }

        public INullableValue<int> NumberBeds { get; }

        public RedBlackTree<INullableValue<int>, Duration> PatientGroupSurgeryDurations { get; }

        public RedBlackTree<INullableValue<int>, Duration> BlockTypeTimeBlockLengths { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<Location, Duration>> DayOperatingRoomOperatingCapacities { get; }

        public RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> SurgeonGroupSubsetPatientGroups { get; }

        public RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> WardSubsetPatientGroups { get; }

        public RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> PatientGroupDayLengthOfStayProbabilities { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> PatientGroupThroughputs { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> Wardα { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> Wardβ { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> Wardγ { get; }
    }
}