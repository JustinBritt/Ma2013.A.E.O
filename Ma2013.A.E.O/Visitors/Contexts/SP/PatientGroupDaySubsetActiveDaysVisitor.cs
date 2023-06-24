namespace Ma2013.A.E.O.Visitors.Contexts.SP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.SP;

    internal sealed class PatientGroupDaySubsetActiveDaysVisitor<TKey, TValue> : IPatientGroupDaySubsetActiveDaysVisitor<TKey, TValue>
        where TKey : Tuple<INullableValue<int>, FhirDateTime>
        where TValue : IImmutableSet<FhirDateTime>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PatientGroupDaySubsetActiveDaysVisitor(
            IAParameterElementFactory AParameterElementFactory,
            Ia a,
            Ma2013.A.E.O.Interfaces.Indices.Common.Id d,
            Ip p,
            Ipa pa)
        {
            this.AParameterElementFactory = AParameterElementFactory;

            this.a = a;

            this.d = d;

            this.p = p;

            this.pa = pa;

            this.RedBlackTree = new RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>>();
        }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private Ia a { get; }

        private Ma2013.A.E.O.Interfaces.Indices.Common.Id d { get; }

        private Ip p { get; }

        private Ipa pa { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IpaCrossJoinElement, ImmutableList<IdIndexElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IpIndexElement pIndexElement = this.p.GetElementAt(
                obj.Key.Item1);

            IaIndexElement aIndexElement = this.a.GetElementAt(
                obj.Key.Item2);

            IpaCrossJoinElement paCrossJoinElement = this.pa.Value.Where(w => w.pIndexElement == pIndexElement && w.aIndexElement == aIndexElement).SingleOrDefault();

            this.RedBlackTree.Add(
                paCrossJoinElement,
                obj.Value.Select(w => this.d.Value[w]).ToImmutableList());
        }
    }
}