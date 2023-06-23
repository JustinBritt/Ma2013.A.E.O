namespace Ma2013.A.E.O.Visitors.Contexts.SP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.SP;

    internal sealed class PatientGroupNumberPatientUpperBoundsVisitor<TKey, TValue> : IPatientGroupNumberPatientUpperBoundsVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupNumberPatientUpperBoundsVisitor(
            IUBParameterElementFactory UBParameterElementFactory,
            Ip p)
        {
            this.UBParameterElementFactory = UBParameterElementFactory;

            this.p = p;

            this.RedBlackTree = new RedBlackTree<IpIndexElement, IUBParameterElement>();
        }

        private IUBParameterElementFactory UBParameterElementFactory { get; }

        private Ip p { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IpIndexElement, IUBParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                pIndexElement,
                this.UBParameterElementFactory.Create(
                    pIndexElement,
                    obj.Value));
        }
    }
}
