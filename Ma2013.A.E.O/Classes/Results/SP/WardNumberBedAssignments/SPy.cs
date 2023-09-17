namespace Ma2013.A.E.O.Classes.Results.SP.WardNumberBedAssignments
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SPy : ISPy
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPy(
            ImmutableList<ISPyResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISPyResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISPyResultElement SPyResultElement in this.Value)
            {
                redBlackTree.Add(
                    SPyResultElement.wIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        SPyResultElement.Value));
            }

            return redBlackTree;
        }
    }
}