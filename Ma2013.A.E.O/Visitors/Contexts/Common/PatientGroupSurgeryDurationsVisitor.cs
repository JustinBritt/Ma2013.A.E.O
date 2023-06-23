namespace Ma2013.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class PatientGroupSurgeryDurationsVisitor<TKey, TValue> : IPatientGroupSurgeryDurationsVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : Duration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupSurgeryDurationsVisitor(
            IdurParameterElementFactory durParameterElementFactory,
            Ip p)
        {
            this.durParameterElementFactory = durParameterElementFactory;

            this.p = p;

            this.RedBlackTree = new RedBlackTree<IpIndexElement, IdurParameterElement>();
        }

        private IdurParameterElementFactory durParameterElementFactory { get; }

        private Ip p { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IpIndexElement, IdurParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                pIndexElement,
                this.durParameterElementFactory.Create(
                    pIndexElement,
                    obj.Value));
        }
    }
}