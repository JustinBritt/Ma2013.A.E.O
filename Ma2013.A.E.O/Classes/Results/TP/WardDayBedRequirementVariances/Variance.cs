namespace Ma2013.A.E.O.Classes.Results.TP.WardDayBedRequirementVariances
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class Variance : IVariance
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Variance(
            ImmutableList<IVarianceResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IVarianceResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement)
        {
            return this.Value
                .Where(x => x.wIndexElement == wIndexElement && x.dIndexElement == dIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ma2013.A.E.O.Interfaces.Indices.Common.Id d,
            Iw w)
        {
            RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<decimal>>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IwIndexElement wIndexElement in w.Value.Values)
            {
                RedBlackTree<FhirDateTime, INullableValue<decimal>> innerRedBlackTree = new RedBlackTree<FhirDateTime, INullableValue<decimal>>(
                    new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

                foreach (IdIndexElement dIndexElement in d.Value.Values)
                {
                    innerRedBlackTree.Add(
                        dIndexElement.Value,
                        nullableValueFactory.Create<decimal>(
                            this.GetElementAtAsdecimal(
                                wIndexElement,
                                dIndexElement)));
                }

                outerRedBlackTree.Add(
                    wIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}