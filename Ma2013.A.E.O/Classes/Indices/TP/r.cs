namespace Ma2013.A.E.O.Classes.Indices.TP
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;

    internal sealed class r : Ir
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public r(
            RedBlackTree<Location, IrIndexElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<Location, IrIndexElement> Value { get; }

        public IrIndexElement GetElementAt(
            Location value)
        {
            return this.Value[value];
        }
    }
}