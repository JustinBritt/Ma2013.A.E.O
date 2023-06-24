namespace Ma2013.A.E.O.Factories.Indices.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Comparers;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class lFactory : IlFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lFactory()
        {
        }

        public Il Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IlIndexElement> value)
        {
            Il index = null;

            try
            {
                index = new l(
                    this.CreateRedBlackTree(
                        nullableValueintComparer,
                        value));
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }

        private RedBlackTree<INullableValue<int>, IlIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IlIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IlIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IlIndexElement>(
                nullableValueintComparer);

            foreach (IlIndexElement lIndexElement in value)
            {
                redBlackTree.Add(
                    lIndexElement.Value,
                    lIndexElement);
            }

            return redBlackTree;
        }
    }
}