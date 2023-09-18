namespace Ma2013.A.E.O.Classes.Results.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPx : ITPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPx(
            ImmutableList<ITPxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<ITPxResultElement> Value { get; }

        public int GetElementAtAsint(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement)
        {
            return this.Value
                .Where(x => x.pIndexElement == pIndexElement && x.aIndexElement == aIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public RedBlackTree<INullableValue<int>, RedBlackTree<FhirDateTime, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Ip p)
        {
            RedBlackTree<INullableValue<int>, RedBlackTree<FhirDateTime, INullableValue<int>>> outerRedBlackTree = new RedBlackTree<INullableValue<int>, RedBlackTree<FhirDateTime, INullableValue<int>>>(
                new Ma2013.A.E.O.Classes.Comparers.NullableValueintComparer());

            foreach (IpIndexElement pIndexElement in p.Value.Values)
            {
                RedBlackTree<FhirDateTime, INullableValue<int>> innerRedBlackTree = new RedBlackTree<FhirDateTime, INullableValue<int>>(
                    new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

                foreach (IaIndexElement aIndexElement in a.Value.Values)
                {
                    innerRedBlackTree.Add(
                        aIndexElement.Value,
                        nullableValueFactory.Create<int>(
                            this.GetElementAtAsint(
                                pIndexElement,
                                aIndexElement)));
                }

                outerRedBlackTree.Add(
                    pIndexElement.Value,
                    innerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}