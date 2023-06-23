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

    internal sealed class DaysVisitor<TKey, TValue> : IDaysVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DaysVisitor(
            IdIndexElementFactory dIndexElementFactory,
            IFhirDateTimeComparer FhirDateTimeComparer)
        {
            this.dIndexElementFactory = dIndexElementFactory;

            this.RedBlackTree = new RedBlackTree<FhirDateTime, IdIndexElement>(
                FhirDateTimeComparer);
        }

        private IdIndexElementFactory dIndexElementFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<FhirDateTime, IdIndexElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.RedBlackTree.Add(
                obj.Value,
                this.dIndexElementFactory.Create(
                    obj.Key.Value.Value,
                    obj.Value));
        }
    }
}