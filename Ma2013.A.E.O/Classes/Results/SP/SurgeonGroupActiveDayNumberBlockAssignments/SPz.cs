namespace Ma2013.A.E.O.Classes.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class SPz : ISPz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPz(
            ImmutableList<ISPzResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ISPzResultElement> Value { get; }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.aIndexElement == aIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Is s)
        {
            RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<int>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<int>>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<FhirDateTime, INullableValue<int>> innerRedBlackTree = new RedBlackTree<FhirDateTime, INullableValue<int>>(
                    new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

                foreach (IaIndexElement aIndexElement in a.Value.Values)
                {
                    innerRedBlackTree.Add(
                        aIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.GetElementAtAsint(
                                sIndexElement,
                                aIndexElement)));
                }

                outerRedBlackTree.Add(
                    sIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}