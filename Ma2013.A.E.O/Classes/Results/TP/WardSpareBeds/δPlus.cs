namespace Ma2013.A.E.O.Classes.Results.TP.WardSpareBeds
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class δPlus : IδPlus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlus(
            ImmutableList<IδPlusResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IδPlusResultElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement)
        {
            return this.Value
                .Where(x => x.wIndexElement == wIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<Organization, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<decimal>> redBlackTree = new RedBlackTree<Organization, INullableValue<decimal>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IδPlusResultElement δPlusResultElement in this.Value)
            {
                redBlackTree.Add(
                    δPlusResultElement.wIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        δPlusResultElement.Value));
            }

            return redBlackTree;
        }
    }
}