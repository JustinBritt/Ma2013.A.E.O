namespace Ma2013.A.E.O.Classes.Results.TP.DayBedRequirementVariances
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class DayBedRequirementVariances : IDayBedRequirementVariances
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementVariances(
            ImmutableList<IDayBedRequirementVariancesResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IDayBedRequirementVariancesResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.dIndexElement == dIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<FhirDateTime, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<FhirDateTime, INullableValue<decimal>> redBlackTree = new RedBlackTree<FhirDateTime, INullableValue<decimal>>(
                new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

            foreach (IDayBedRequirementVariancesResultElement dayBedRequirementVariancesResultElement in this.Value)
            {
                redBlackTree.Add(
                    dayBedRequirementVariancesResultElement.dIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        dayBedRequirementVariancesResultElement.Value));
            }

            return redBlackTree;
        }
    }
}