namespace Ma2013.A.E.O.Interfaces.Contexts.SP
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface ISPOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        INullableValue<decimal> TotalFinancialContribution { get; }

        RedBlackTree<INullableValue<int>, RedBlackTree<FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        RedBlackTree<Organization, INullableValue<int>> WardNumberBedAssignments { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<int>>> SurgeonGroupActiveDayNumberBlockAssignments { get; }
    }
}