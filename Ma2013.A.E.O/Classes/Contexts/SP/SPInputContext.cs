namespace Ma2013.A.E.O.Classes.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Interfaces.Contexts.SP;

    internal sealed class SPInputContext : ISPInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPInputContext(
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
            ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> patientGroupNumberPatientUpperBounds)
        {
            this.ActiveDays = activeDays;

            this.Days = days;

            this.PatientGroups = patientGroups;

            this.SurgeonGroups = surgeonGroups;

            this.Wards = wards;

            this.PatientGroupDaySubsetActiveDays = patientGroupDaySubsetActiveDays;

            this.NumberBeds = numberBeds;

            this.NumberBlocks = numberBlocks;

            this.PatientGroupSurgeryDurations = patientGroupSurgeryDurations;

            this.PatientGroupNumberPatientLowerBounds = patientGroupNumberPatientLowerBounds;

            this.TimeBlockLength = timeBlockLength;

            this.SurgeonGroupSubsetPatientGroups = surgeonGroupSubsetPatientGroups;

            this.WardSubsetPatientGroups = wardSubsetPatientGroups;

            this.PatientGroupProfits = patientGroupProfits;

            this.PatientGroupThroughputs = patientGroupThroughputs;

            this.PatientGroupNumberPatientUpperBounds = patientGroupNumberPatientUpperBounds;
        }

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> ActiveDays { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> Days { get; }

        public ImmutableSortedSet<INullableValue<int>> PatientGroups { get; }

        public Bundle SurgeonGroups { get; }

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        public ImmutableList<Tuple<INullableValue<int>, FhirDateTime, FhirDateTime>> PatientGroupDaySubsetActiveDays { get; }

        public INullableValue<int> NumberBeds { get; }

        public INullableValue<int> NumberBlocks { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, Duration>> PatientGroupSurgeryDurations { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupNumberPatientLowerBounds { get; }

        public Duration TimeBlockLength { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonGroupSubsetPatientGroups { get; }

        public ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardSubsetPatientGroups { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, Money>> PatientGroupProfits { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupThroughputs { get; }

        public ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupNumberPatientUpperBounds { get; }
    }
}