namespace Ma2013.A.E.O.Factories.Contexts.SP
{
    using System;
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
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> surgeonGroupSubsetPatientGroups,
            RedBlackTree<Organization, ImmutableSortedSet<INullableValue<int>>> wardSubsetPatientGroups,
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