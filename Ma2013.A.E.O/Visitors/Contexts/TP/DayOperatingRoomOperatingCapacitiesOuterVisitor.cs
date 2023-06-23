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
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class DayOperatingRoomOperatingCapacitiesOuterVisitor<TKey, TValue> : IDayOperatingRoomOperatingCapacitiesOuterVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : RedBlackTree<Location, Duration>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayOperatingRoomOperatingCapacitiesOuterVisitor(
            IORdayParameterElementFactory ORdayParameterElementFactory,
            Ia a,
            Ir r)
        {
            this.ORdayParameterElementFactory = ORdayParameterElementFactory;

            this.a = a;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>>();
        }

        private IORdayParameterElementFactory ORdayParameterElementFactory { get; }

        private Ia a { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IaIndexElement aIndexElement = this.a.GetElementAt(
                obj.Key);

            RedBlackTree<Location, Duration> value = obj.Value;

            var innerVisitor = new DayOperatingRoomOperatingCapacitiesInnerVisitor<Location, Duration>(
                this.ORdayParameterElementFactory,
                aIndexElement,
                this.r);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                aIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}