namespace Ma2013.A.E.O.Classes.Results.TP.WardNumberAssignedActiveDays
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class WardNumberAssignedActiveDays : IWardNumberAssignedActiveDays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedActiveDays(
            ImmutableList<IWardNumberAssignedActiveDaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWardNumberAssignedActiveDaysResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IWardNumberAssignedActiveDaysResultElement wardNumberAssignedActiveDaysResultElement in this.Value)
            {
                redBlackTree.Add(
                    wardNumberAssignedActiveDaysResultElement.wIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        wardNumberAssignedActiveDaysResultElement.Value));
            }

            return redBlackTree;
        }
    }
}