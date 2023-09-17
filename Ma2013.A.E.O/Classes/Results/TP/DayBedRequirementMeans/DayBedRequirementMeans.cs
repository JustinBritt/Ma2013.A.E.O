namespace Ma2013.A.E.O.Classes.Results.TP.DayBedRequirementMeans
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class DayBedRequirementMeans : IDayBedRequirementMeans
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayBedRequirementMeans(
            ImmutableList<IDayBedRequirementMeansResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IDayBedRequirementMeansResultElement> Value { get; }

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
            RedBlackTree<FhirDateTime, INullableValue<decimal>> redBlackTree = new RedBlackTree<FhirDateTime, INullableValue<decimal>>();

            foreach (IDayBedRequirementMeansResultElement dayBedRequirementMeansResultElement in this.Value)
            {
                redBlackTree.Add(
                    dayBedRequirementMeansResultElement.dIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        dayBedRequirementMeansResultElement.Value));
            }

            return redBlackTree;
        }
    }
}