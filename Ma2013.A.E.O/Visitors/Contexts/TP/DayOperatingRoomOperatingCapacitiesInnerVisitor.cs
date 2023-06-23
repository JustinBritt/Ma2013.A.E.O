namespace Ma2013.A.E.O.Visitors.Contexts.TP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class DayOperatingRoomOperatingCapacitiesInnerVisitor<TKey, TValue> : IDayOperatingRoomOperatingCapacitiesInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : Duration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DayOperatingRoomOperatingCapacitiesInnerVisitor(
            IORdayParameterElementFactory ORdayParameterElementFactory,
            IaIndexElement aIndexElement,
            Ir r)
        {
            this.ORdayParameterElementFactory = ORdayParameterElementFactory;

            this.aIndexElement = aIndexElement;

            this.r = r;

            this.RedBlackTree = new RedBlackTree<IrIndexElement, IORdayParameterElement>();
        }

        private IORdayParameterElementFactory ORdayParameterElementFactory { get; }

        private IaIndexElement aIndexElement { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, IORdayParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                rIndexElement,
                this.ORdayParameterElementFactory.Create(
                    this.aIndexElement,
                    rIndexElement,
                    obj.Value));
        }
    }
}