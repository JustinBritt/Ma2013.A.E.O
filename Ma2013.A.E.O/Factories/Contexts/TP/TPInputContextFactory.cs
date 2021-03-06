namespace Ma2013.A.E.O.Factories.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Ma2013.A.E.O.Classes.Contexts.TP;
    using Ma2013.A.E.O.Interfaces.Contexts.TP;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.TP;

    internal sealed class TPInputContextFactory : ITPInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPInputContextFactory()
        {
        }

        public ITPInputContext Create(
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
            ITPInputContext context = null;

            try
            {
                context = new TPInputContext(
                    activeDays,
                    days,
                    blockTypes,
                    lengthOfStayDays,
                    patientGroups,
                    operatingRooms,
                    surgeonGroups,
                    wards,
                    numberBeds,
                    patientGroupSurgeryDurations,
                    blockTypeTimeBlockLengths,
                    dayOperatingRoomOperatingCapacities,
                    surgeonGroupSubsetPatientGroups,
                    wardSubsetPatientGroups,
                    patientGroupDayLengthOfStayProbabilities,
                    patientGroupThroughputs,
                    wardα,
                    wardβ,
                    wardγ);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}