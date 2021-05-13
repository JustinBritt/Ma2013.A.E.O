namespace Ma2013.A.E.O.Interfaces.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface ITPInputContext
    {
        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> ActiveDays { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> Days { get; }

        ImmutableList<INullableValue<int>> BlockTypes { get; }

        ImmutableList<INullableValue<int>> LengthOfStayDays { get; }

        ImmutableList<INullableValue<int>> PatientGroups { get; }

        Bundle OperatingRooms { get; }

        Bundle SurgeonGroups { get; }

        ImmutableList<Tuple<Organization, ImmutableList<Organization>>> Wards { get; }

        INullableValue<int> NumberBeds { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, Duration>> PatientGroupSurgeryDurations { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, Duration>> BlockTypeTimeBlockLengths { get; }

        ImmutableList<Tuple<FhirDateTime, Location, Duration>> DayOperatingRoomOperatingCapacities { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> SurgeonGroupSubsetPatientGroups { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<int>>> WardSubsetPatientGroups { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<int>, FhirDecimal>> PatientGroupDayLengthOfStayProbabilities { get; }

        ImmutableList<KeyValuePair<INullableValue<int>, INullableValue<int>>> PatientGroupThroughputs { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> Wardα { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> Wardβ { get; }

        ImmutableList<KeyValuePair<Organization, INullableValue<decimal>>> Wardγ { get; }
    }
}