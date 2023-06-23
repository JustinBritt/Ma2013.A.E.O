namespace Ma2013.A.E.O.Visitors.Contexts.TP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class PatientGroupThroughputsVisitor<TKey, TValue> : IPatientGroupThroughputsVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupThroughputsVisitor(
            ITHRParameterElementFactory THRParameterElementFactory,
            Ip p)
        {
            this.THRParameterElementFactory = THRParameterElementFactory;

            this.p = p;

            this.RedBlackTree = new RedBlackTree<IpIndexElement, ITHRParameterElement>();
        }

        private ITHRParameterElementFactory THRParameterElementFactory { get; }

        public Ip p { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IpIndexElement, ITHRParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                pIndexElement,
                this.THRParameterElementFactory.Create(
                    pIndexElement,
                    obj.Value));
        }
    }
}