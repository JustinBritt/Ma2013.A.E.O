namespace Ma2013.A.E.O.Classes.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.Contexts.SP;

    internal sealed class SPInputContext : ISPInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPInputContext(
            RedBlackTree<INullableValue<int>, FhirDateTime> activeDays,
            RedBlackTree<INullableValue<int>, FhirDateTime> days,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle surgeonGroups,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> wards,
            RedBlackTree<Tuple<INullableValue<int>, FhirDateTime>, ImmutableSortedSet<FhirDateTime>> patientGroupDaySubsetActiveDays,
            INullableValue<int> numberBeds,
            INullableValue<int> numberBlocks,
            RedBlackTree<INullableValue<int>, Duration> patientGroupSurgeryDurations,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupNumberPatientLowerBounds,
            Duration timeBlockLength,
            RedBlackTree<Organization, INullableValue<int>> surgeonGroupSubsetPatientGroups,
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> wardSubsetPatientGroups,
            RedBlackTree<INullableValue<int>, Money> patientGroupProfits,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupNumberPatientUpperBounds)
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

            this.PatientGroupNumberPatientUpperBounds = patientGroupNumberPatientUpperBounds;
        }

        public RedBlackTree<INullableValue<int>, FhirDateTime> ActiveDays { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> Days { get; }

        public ImmutableSortedSet<INullableValue<int>> PatientGroups { get; }

        public Bundle SurgeonGroups { get; }

        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        public RedBlackTree<Tuple<INullableValue<int>, FhirDateTime>, ImmutableSortedSet<FhirDateTime>> PatientGroupDaySubsetActiveDays { get; }

        public INullableValue<int> NumberBeds { get; }

        public INullableValue<int> NumberBlocks { get; }

        public RedBlackTree<INullableValue<int>, Duration> PatientGroupSurgeryDurations { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> PatientGroupNumberPatientLowerBounds { get; }

        public Duration TimeBlockLength { get; }

        public RedBlackTree<Organization, INullableValue<int>> SurgeonGroupSubsetPatientGroups { get; }

        public RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> WardSubsetPatientGroups { get; }

        public RedBlackTree<INullableValue<int>, Money> PatientGroupProfits { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> PatientGroupNumberPatientUpperBounds { get; }
    }
}