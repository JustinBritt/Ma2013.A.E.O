namespace Ma2013.A.E.O.Classes.Results.TP.WardNumberBedAssignments
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPy : ITPy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPy(
            ImmutableList<ITPyResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITPyResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ITPyResultElement TPyResultElement in this.Value)
            {
                redBlackTree.Add(
                    TPyResultElement.wIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        TPyResultElement.Value));
            }

            return redBlackTree;
        }
    }
}