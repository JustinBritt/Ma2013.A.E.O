namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberAssignedOperatingRooms
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedOperatingRooms;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonGroupNumberAssignedOperatingRooms : ISurgeonGroupNumberAssignedOperatingRooms
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedOperatingRooms(
            ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonGroupNumberAssignedOperatingRoomsResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgeonGroupNumberAssignedOperatingRoomsResultElement surgeonGroupNumberAssignedOperatingRoomsResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgeonGroupNumberAssignedOperatingRoomsResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgeonGroupNumberAssignedOperatingRoomsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}