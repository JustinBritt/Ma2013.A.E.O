namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonGroupNumberAssignedActiveDays : ISurgeonGroupNumberAssignedActiveDays
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDays(
            ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgeonGroupNumberAssignedActiveDaysResultElement surgeonGroupNumberAssignedActiveDaysResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgeonGroupNumberAssignedActiveDaysResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgeonGroupNumberAssignedActiveDaysResultElement.Value));
            }

            return redBlackTree;
        }
    }
}