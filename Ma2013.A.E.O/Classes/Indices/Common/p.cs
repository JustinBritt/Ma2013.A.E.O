namespace Ma2013.A.E.O.Classes.Indices.Common
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;

    internal sealed class p : Ip
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public p(
            RedBlackTree<INullableValue<int>, IpIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IpIndexElement> Value { get; }

        public IpIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}