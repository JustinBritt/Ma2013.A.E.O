namespace Ma2013.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class SurgeonGroupSubsetPatientGroupsVisitor<TKey, TValue> : ISurgeonGroupSubsetPatientGroupsVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupSubsetPatientGroupsVisitor(
            IPParameterElementFactory PParameterElementFactory,
            Ip p,
            Is s)
        {
            this.PParameterElementFactory = PParameterElementFactory;

            this.p = p;

            this.s = s;

            this.RedBlackTree = new RedBlackTree<IsIndexElement, IPParameterElement>();
        }

        private IPParameterElementFactory PParameterElementFactory { get; }

        private Ip p { get; }

        private Is s { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IsIndexElement, IPParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IsIndexElement sIndexElement = this.s.GetElementAt(
                obj.Key);

            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Value);

            this.RedBlackTree.Add(
                sIndexElement,
                this.PParameterElementFactory.Create(
                    sIndexElement,
                    pIndexElement));
        }
    }
}