namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupNumberPatients
{
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SurgeonGroupNumberPatients : ISurgeonGroupNumberPatients
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatients(
            ImmutableList<ISurgeonGroupNumberPatientsResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISurgeonGroupNumberPatientsResultElement> Value { get; }

        public RedBlackTree<Organization, INullableValue<int>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            RedBlackTree<Organization, INullableValue<int>> redBlackTree = new RedBlackTree<Organization, INullableValue<int>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (ISurgeonGroupNumberPatientsResultElement surgeonGroupNumberPatientsResultElement in this.Value)
            {
                redBlackTree.Add(
                    surgeonGroupNumberPatientsResultElement.sIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        surgeonGroupNumberPatientsResultElement.Value));
            }

            return redBlackTree;
        }
    }
}