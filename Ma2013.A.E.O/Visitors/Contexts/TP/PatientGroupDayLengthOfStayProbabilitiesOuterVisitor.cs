namespace Ma2013.A.E.O.Visitors.Contexts.TP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class PatientGroupDayLengthOfStayProbabilitiesOuterVisitor<TKey, TValue> : IPatientGroupDayLengthOfStayProbabilitiesOuterVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupDayLengthOfStayProbabilitiesOuterVisitor(
            IprobParameterElementFactory probParameterElementFactory,
            Il l,
            Ip p)
        {
            this.probParameterElementFactory = probParameterElementFactory;

            this.l = l;

            this.p = p;

            this.RedBlackTree = new RedBlackTree<IpIndexElement, RedBlackTree<IlIndexElement, IprobParameterElement>>();
        }

        private IprobParameterElementFactory probParameterElementFactory { get; }

        private Il l { get; }

        private Ip p { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IpIndexElement, RedBlackTree<IlIndexElement, IprobParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Key);

            RedBlackTree< INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            var innerVisitor = new PatientGroupDayLengthOfStayProbabilitiesInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.probParameterElementFactory,
                pIndexElement,
                this.l);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                pIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}