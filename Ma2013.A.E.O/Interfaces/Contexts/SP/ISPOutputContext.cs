namespace Ma2013.A.E.O.Interfaces.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ISPOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        INullableValue<decimal> Gap { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        INullableValue<decimal> TotalFinancialContribution { get; }

        ImmutableList<Tuple<INullableValue<int>, FhirDateTime, INullableValue<int>>> PatientGroupActiveDayNumberPatientAssignments { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardNumberBedAssignments { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, INullableValue<int>>> SurgeonGroupActiveDayNumberBlockAssignments { get; }
    }
}