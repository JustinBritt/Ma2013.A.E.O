namespace Ma2013.A.E.O.Visitors.Contexts.TP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class WardβVisitor<TKey, TValue> : IWardβVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<decimal>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WardβVisitor(
            IβParameterElementFactory βParameterElementFactory,
            Iw w)
        {
            this.βParameterElementFactory = βParameterElementFactory;

            this.w = w;

            this.RedBlackTree = new RedBlackTree<IwIndexElement, IβParameterElement>();
        }

        private IβParameterElementFactory βParameterElementFactory { get; }

        private Iw w { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IwIndexElement, IβParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IwIndexElement wIndexElement = this.w.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                wIndexElement,
                this.βParameterElementFactory.Create(
                    wIndexElement,
                    obj.Value));
        }
    }
}