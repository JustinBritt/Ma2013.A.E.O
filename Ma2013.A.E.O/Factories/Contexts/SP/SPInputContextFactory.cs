namespace Ma2013.A.E.O.Factories.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Contexts.SP;
    using Ma2013.A.E.O.Interfaces.Contexts.SP;
    using Ma2013.A.E.O.InterfacesFactories.Contexts.SP;

    internal sealed class SPInputContextFactory : ISPInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPInputContextFactory()
        {
        }

        public ISPInputContext Create(
            RedBlackTree<INullableValue<int>, FhirDateTime> activeDays,
            ImmutableList<KeyValuePair<INullableValue<int>, FhirDateTime>> days,
            ImmutableSortedSet<INullableValue<int>> patientGroups,
            Bundle surgeonGroups,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> wards,
            ImmutableList<Tuple<INullableValue<int>, FhirDateTime, FhirDateTime>> patientGroupDaySubsetActiveDays,
            INullableValue<int> numberBeds,
            INullableValue<int> numberBlocks,
            RedBlackTree<INullableValue<int>, Duration> patientGroupSurgeryDurations,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupNumberPatientLowerBounds,
            Duration timeBlockLength,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            ImmutableList<KeyValuePair<Organization, INullableValue<int>>> wardSubsetPatientGroups,
            RedBlackTree<INullableValue<int>, Money> patientGroupProfits,
            RedBlackTree<INullableValue<int>, INullableValue<int>> patientGroupNumberPatientUpperBounds)
        {
            ISPInputContext context = null;

            try
            {
                context = new SPInputContext(
                    activeDays,
                    days,
                    patientGroups,
                    surgeonGroups,
                    wards,
                    patientGroupDaySubsetActiveDays,
                    numberBeds,
                    numberBlocks,
                    patientGroupSurgeryDurations,
                    patientGroupNumberPatientLowerBounds,
                    timeBlockLength,
                    surgeonGroupSubsetPatientGroups,
                    wardSubsetPatientGroups,
                    patientGroupProfits,
                    patientGroupNumberPatientUpperBounds);
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