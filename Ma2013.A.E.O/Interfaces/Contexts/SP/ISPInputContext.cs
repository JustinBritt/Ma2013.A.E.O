namespace Ma2013.A.E.O.Interfaces.Contexts.SP
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface ISPInputContext
    {
        RedBlackTree<INullableValue<int>, FhirDateTime> ActiveDays { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> Days { get; }

        ImmutableSortedSet<INullableValue<int>> PatientGroups { get; }

        Bundle SurgeonGroups { get; }

        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        RedBlackTree<Tuple<INullableValue<int>, FhirDateTime>, ImmutableSortedSet<FhirDateTime>> PatientGroupDaySubsetActiveDays { get; }

        INullableValue<int> NumberBeds { get; }

        INullableValue<int> NumberBlocks { get; }

        RedBlackTree<INullableValue<int>, Duration> PatientGroupSurgeryDurations { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> PatientGroupNumberPatientLowerBounds { get; }

        Duration TimeBlockLength { get; }

        RedBlackTree<Organization, INullableValue<int>> SurgeonGroupSubsetPatientGroups { get; }

        RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> WardSubsetPatientGroups { get; }

        RedBlackTree<INullableValue<int>, Money> PatientGroupProfits { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> PatientGroupNumberPatientUpperBounds { get; }
    }
}