namespace Ma2013.A.E.O.Classes.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class TPz : ITPz
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPz(
            ImmutableList<ITPzResultElement> value)
        {
            this.Value = value;
        }

        public bool GetElementAtAsbool(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.aIndexElement == aIndexElement && x.rIndexElement == rIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value)
                .SingleOrDefault();
        }

        public int GetElementAtAsint(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.sIndexElement == sIndexElement && x.aIndexElement == aIndexElement && x.rIndexElement == rIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value ? 1 : 0)
                .SingleOrDefault();
        }

        public ImmutableList<ITPzResultElement> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ia a,
            Ik k,
            Ir r,
            Is s)
        {
            RedBlackTree<Organization, RedBlackTree<FhirDateTime, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>>> outerRedBlackTree = new RedBlackTree<Organization, RedBlackTree<FhirDateTime, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>>>(
                new Ma2013.A.E.O.Classes.Comparers.OrganizationComparer());

            foreach (IsIndexElement sIndexElement in s.Value.Values)
            {
                RedBlackTree<FhirDateTime, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>> firstInnerRedBlackTree = new RedBlackTree<FhirDateTime, RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>>(
                    new Ma2013.A.E.O.Classes.Comparers.FhirDateTimeComparer());

                foreach (IaIndexElement aIndexElement in a.Value.Values)
                {
                    RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>> secondInnerRedBlackTree = new RedBlackTree<Location, RedBlackTree<INullableValue<int>, INullableValue<bool>>>(
                        new Ma2013.A.E.O.Classes.Comparers.LocationComparer());

                    foreach (IrIndexElement rIndexElement in r.Value.Values)
                    {
                        RedBlackTree<INullableValue<int>, INullableValue<bool>> thirdInnerRedBlackTree = new RedBlackTree<INullableValue<int>, INullableValue<bool>>(
                            new Ma2013.A.E.O.Classes.Comparers.NullableValueintComparer());

                        foreach (IkIndexElement kIndexElement in k.Value.Values)
                        {
                            thirdInnerRedBlackTree.Add(
                                kIndexElement.Value,
                                nullableValueFactory.Create<bool>(
                                    this.GetElementAtAsbool(
                                        sIndexElement,
                                        aIndexElement,
                                        rIndexElement,
                                        kIndexElement)));
                        }

                        secondInnerRedBlackTree.Add(
                            rIndexElement.Value,
                            thirdInnerRedBlackTree);
                    }

                    firstInnerRedBlackTree.Add(
                        aIndexElement.Value,
                        secondInnerRedBlackTree);
                }

                outerRedBlackTree.Add(
                    sIndexElement.Value,
                    firstInnerRedBlackTree);
            }

            return outerRedBlackTree;
        }
    }
}