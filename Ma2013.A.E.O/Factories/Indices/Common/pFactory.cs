namespace Ma2013.A.E.O.Factories.Indices.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Comparers;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.Indices.Common;

    internal sealed class pFactory : IpFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pFactory()
        {
        }

        public Ip Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IpIndexElement> value)
        {
            Ip index = null;

            try
            {
                index = new p(
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

        private RedBlackTree<INullableValue<int>, IpIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IpIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IpIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IpIndexElement>(
                nullableValueintComparer);

            foreach (IpIndexElement pIndexElement in value)
            {
                redBlackTree.Add(
                    pIndexElement.Value,
                    pIndexElement);
            }

            return redBlackTree;
        }
    }
}