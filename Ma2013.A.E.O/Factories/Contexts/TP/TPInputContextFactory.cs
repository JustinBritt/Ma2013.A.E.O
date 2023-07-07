namespace Ma2013.A.E.O.Factories.Contexts.TP
{
    using System;
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
            RedBlackTree<INullableValue<int>, FhirDateTime> days,
            ImmutableSortedSet<INullableValue<int>> blockTypes,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle operatingRooms,
            Bundle surgeonGroups,
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> wards,
            INullableValue<int> numberBeds,
            RedBlackTree<INullableValue<int>, Duration> patientGroupSurgeryDurations,
            RedBlackTree<INullableValue<int>, Duration> blockTypeTimeBlockLengths,
            RedBlackTree<FhirDateTime, RedBlackTree<Location, Duration>> dayOperatingRoomOperatingCapacities,
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> wardSubsetPatientGroups,
            RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> patientGroupDayLengthOfStayProbabilities,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupThroughputs,
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