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
    
    internal sealed class wFactory : IwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wFactory()
        {
        }

        public Iw Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IwIndexElement> value)
        {
            Iw index = null;

            try
            {
                index = new w(
                    this.CreateRedBlackTree(
                        organizationComparer,
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

        private RedBlackTree<Organization, IwIndexElement> CreateRedBlackTree(
            IOrganizationComparer organizationComparer,
            ImmutableList<IwIndexElement> value)
        {
            RedBlackTree<Organization, IwIndexElement> redBlackTree = new RedBlackTree<Organization, IwIndexElement>(
                organizationComparer);

            foreach (IwIndexElement wIndexElement in value)
            {
                redBlackTree.Add(
                    wIndexElement.Value,
                    wIndexElement);
            }

            return redBlackTree;
        }
    }
}