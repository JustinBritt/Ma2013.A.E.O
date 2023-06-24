namespace Ma2013.A.E.O.Classes.Indices.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;

    internal sealed class k : Ik
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public k(
            RedBlackTree<INullableValue<int>, IkIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<INullableValue<int>, IkIndexElement> Value { get; }

        public IkIndexElement GetElementAt(
            INullableValue<int> value)
        {
            return this.Value[value];
        }
    }
}