namespace Ma2013.A.E.O.Visitors.Contexts.Common
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.Comparers;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.Common;

    internal sealed class ActiveDaysVisitor<TKey, TValue> : IActiveDaysVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActiveDaysVisitor(
            IaIndexElementFactory aIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            this.aIndexElementFactory = aIndexElementFactory;

            this.RedBlackTree = new RedBlackTree<FhirDateTime, IaIndexElement>(
                FhirDateTimeComparer);
        }

        private IaIndexElementFactory aIndexElementFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, IaIndexElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Value,
                this.aIndexElementFactory.Create(
                    obj.Key.Value.Value,
                    obj.Value));
        }
    }
}