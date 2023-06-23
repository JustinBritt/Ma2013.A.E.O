namespace Ma2013.A.E.O.Visitors.Contexts.TP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class PatientGroupDayLengthOfStayProbabilitiesInnerVisitor<TKey, TValue> : IPatientGroupDayLengthOfStayProbabilitiesInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupDayLengthOfStayProbabilitiesInnerVisitor(
            IprobParameterElementFactory probParameterElementFactory,
            IpIndexElement pIndexElement,
            Il l)
        {
            this.probParameterElementFactory = probParameterElementFactory;

            this.pIndexElement = pIndexElement;

            this.l = l;

            this.RedBlackTree = new RedBlackTree<IlIndexElement, IprobParameterElement>();
        }

        private IprobParameterElementFactory probParameterElementFactory { get; }

        private IpIndexElement pIndexElement { get; }

        private Il l { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IlIndexElement, IprobParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IlIndexElement lIndexElement = this.l.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                lIndexElement,
                this.probParameterElementFactory.Create(
                    this.pIndexElement,
                    lIndexElement,
                    obj.Value));
        }
    }
}