namespace Ma2013.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class WardSubsetPatientGroupsVisitor<TKey, TValue> : IWardSubsetPatientGroupsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : IImmutableSet<INullableValue<int>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardSubsetPatientGroupsVisitor(
            IPParameterElementFactory PParameterElementFactory,
            Ip p,
            Iw w)
        {
            this.PParameterElementFactory = PParameterElementFactory;

            this.p = p;

            this.w = w;

            this.RedBlackTree = new RedBlackTree<IwIndexElement, IPParameterElement>();
        }

        private IPParameterElementFactory PParameterElementFactory { get; }

        private Ip p { get; }

        private Iw w { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IwIndexElement, IPParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IwIndexElement wIndexElement = this.w.GetElementAt(
                obj.Key);

            foreach (INullableValue<int> item in obj.Value)
            {
                IpIndexElement pIndexElement = this.p.GetElementAt(
                    item);

                this.RedBlackTree.Add(
                    wIndexElement,
                    this.PParameterElementFactory.Create(
                        wIndexElement,
                        pIndexElement));
            }
        }
    }
}