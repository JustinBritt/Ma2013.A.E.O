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
    
    internal sealed class rFactory : IrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rFactory()
        {
        }

        public Ir Create(
            ILocationComparer locationComparer,
            ImmutableList<IrIndexElement> value)
        {
            Ir index = null;

            try
            {
                index = new r(
                    this.CreateRedBlackTree(
                        locationComparer,
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

        private RedBlackTree<Location, IrIndexElement> CreateRedBlackTree(
            ILocationComparer locationComparer,
            ImmutableList<IrIndexElement> value)
        {
            RedBlackTree<Location, IrIndexElement> redBlackTree = new RedBlackTree<Location, IrIndexElement>(
                locationComparer);

            foreach (IrIndexElement rIndexElement in value)
            {
                redBlackTree.Add(
                    rIndexElement.Value,
                    rIndexElement);
            }

            return redBlackTree;
        }
    }
}