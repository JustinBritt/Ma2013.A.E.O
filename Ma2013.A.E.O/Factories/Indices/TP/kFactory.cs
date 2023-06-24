﻿namespace Ma2013.A.E.O.Factories.Indices.TP
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

    internal sealed class kFactory : IkFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kFactory()
        {
        }

        public Ik Create(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IkIndexElement> value)
        {
            Ik index = null;

            try
            {
                index = new k(
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

        private RedBlackTree<INullableValue<int>, IkIndexElement> CreateRedBlackTree(
            INullableValueintComparer nullableValueintComparer,
            ImmutableList<IkIndexElement> value)
        {
            RedBlackTree<INullableValue<int>, IkIndexElement> redBlackTree = new RedBlackTree<INullableValue<int>, IkIndexElement>(
                nullableValueintComparer);

            foreach (IkIndexElement kIndexElement in value)
            {
                redBlackTree.Add(
                    kIndexElement.Value,
                    kIndexElement);
            }

            return redBlackTree;
        }
    }
}