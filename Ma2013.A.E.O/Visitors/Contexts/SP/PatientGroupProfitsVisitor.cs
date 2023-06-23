namespace Ma2013.A.E.O.Visitors.Contexts.SP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.SP;

    internal sealed class PatientGroupProfitsVisitor<TKey, TValue> : IPatientGroupProfitsVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : Money
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupProfitsVisitor(
            IrParameterElementFactory rParameterElementFactory,
            Ip p)
        {
            this.rParameterElementFactory = rParameterElementFactory;

            this.p = p;

            this.RedBlackTree = new RedBlackTree<IpIndexElement, IrParameterElement>();
        }

        private IrParameterElementFactory rParameterElementFactory { get; }

        private Ip p { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IpIndexElement, IrParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                pIndexElement,
                this.rParameterElementFactory.Create(
                    pIndexElement,
                    obj.Value));
        }
    }
}