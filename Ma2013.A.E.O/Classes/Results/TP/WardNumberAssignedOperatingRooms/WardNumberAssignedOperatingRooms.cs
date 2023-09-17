namespace Ma2013.A.E.O.Classes.Results.TP.WardNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class WardNumberAssignedOperatingRooms : IWardNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardNumberAssignedOperatingRooms(
            ImmutableList<IWardNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWardNumberAssignedOperatingRoomsResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IWardNumberAssignedOperatingRoomsResultElement wardNumberAssignedOperatingRoomsResultElement in this.Value)
            {
                redBlackTree.Add(
                    wardNumberAssignedOperatingRoomsResultElement.wIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        wardNumberAssignedOperatingRoomsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}