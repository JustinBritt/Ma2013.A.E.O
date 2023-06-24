namespace Ma2013.A.E.O.Classes.Indices.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            RedBlackTree<Organization, IwIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Organization, IwIndexElement> Value { get; }

        public IwIndexElement GetElementAt(
            Organization value)
        {
            return this.Value[value];
        }
    }
}