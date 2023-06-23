namespace Ma2013.A.E.O.Visitors.Contexts.TP
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesFactories.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.InterfacesVisitors.Contexts.TP;

    internal sealed class BlockTypeTimeBlockLengthsVisitor<TKey, TValue> : IBlockTypeTimeBlockLengthsVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : Duration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BlockTypeTimeBlockLengthsVisitor(
            ILengthParameterElementFactory lengthParameterElementFactory,
            Ik k)
        {
            this.LengthParameterElementFactory = lengthParameterElementFactory;

            this.k = k;

            this.RedBlackTree = new RedBlackTree<IkIndexElement, ILengthParameterElement>();
        }

        private ILengthParameterElementFactory LengthParameterElementFactory { get; }

        private Ik k { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IkIndexElement, ILengthParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IkIndexElement kIndexElement = this.k.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                kIndexElement,
                this.LengthParameterElementFactory.Create(
                    kIndexElement,
                    obj.Value));
        }
    }
}