namespace Ma2013.A.E.O.Factories.Contexts.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

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