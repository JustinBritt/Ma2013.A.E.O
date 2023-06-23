namespace Ma2013.A.E.O.Classes.Contexts.TP
{
    using System;
    using System.Collections.Generic;
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
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> days,
            ImmutableSortedSet<INullableValue<int>> blockTypes,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
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

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> Days { get; }

        public ImmutableSortedSet<INullableValue<int>> BlockTypes { get; }

        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        public ImmutableSortedSet<INullableValue<int>> PatientGroups { get; }

        public Bundle OperatingRooms { get; }

        public Bundle SurgeonGroups { get; }

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        public INullableValue<int> NumberBeds { get; }

        public RedBlackTree<INullableValue<int>, Duration> PatientGroupSurgeryDurations { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, Duration>> BlockTypeTimeBlockLengths { get; }

        public ImmutableList<Tuple<FhirDateTime, Location, Duration>> DayOperatingRoomOperatingCapacities { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonGroupSubsetPatientGroups { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardSubsetPatientGroups { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<int>, INullableValue<decimal>>> PatientGroupDayLengthOfStayProbabilities { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupThroughputs { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> Wardα { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> Wardβ { get; }

        public RedBlackTree<Organization, INullableValue<decimal>> Wardγ { get; }
    }
}