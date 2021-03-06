namespace Ma2013.A.E.O.Classes.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Contexts.TP;

    public sealed class TPInputContext : ITPInputContext
    { 
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPInputContext(
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> activeDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> days,
            ImmutableList<INullableValue<int>> blockTypes,
            ImmutableList<INullableValue<int>> lengthOfStayDays,
            ImmutableList<INullableValue<int>> patientGroups,
            Bundle operatingRooms,
            Bundle surgeonGroups,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> wards,
            INullableValue<int> numberBeds,
            ImmutableList<KeyValuePair<INullableValue<int>, Duration>> patientGroupSurgeryDurations,
            ImmutableList<KeyValuePair<INullableValue<int>, Duration>> blockTypeTimeBlockLengths,
            ImmutableList<Tuple<FhirDateTime, Location, Duration>> dayOperatingRoomOperatingCapacities,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> wardSubsetPatientGroups,
            ImmutableList<Tuple<INullableValue<int>, INullableValue<int>, FhirDecimal>> patientGroupDayLengthOfStayProbabilities,
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> patientGroupThroughputs,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> wardα,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> wardβ,
            ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> wardγ)
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

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> ActiveDays { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> Days { get; }

        public ImmutableList<INullableValue<int>> BlockTypes { get; }

        public ImmutableList<INullableValue<int>> LengthOfStayDays { get; }

        public ImmutableList<INullableValue<int>> PatientGroups { get; }

        public Bundle OperatingRooms { get; }

        public Bundle SurgeonGroups { get; }

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        public INullableValue<int> NumberBeds { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, Duration>> PatientGroupSurgeryDurations { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, Duration>> BlockTypeTimeBlockLengths { get; }

        public ImmutableList<Tuple<FhirDateTime, Location, Duration>> DayOperatingRoomOperatingCapacities { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonGroupSubsetPatientGroups { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardSubsetPatientGroups { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<int>, FhirDecimal>> PatientGroupDayLengthOfStayProbabilities { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupThroughputs { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> Wardα { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> Wardβ { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> Wardγ { get; }
    }
}