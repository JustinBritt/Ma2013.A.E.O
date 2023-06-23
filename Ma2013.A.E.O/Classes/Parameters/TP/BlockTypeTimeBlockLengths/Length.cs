namespace Ma2013.A.E.O.Classes.Parameters.TP.BlockTypeTimeBlockLengths
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;

    internal sealed class Length : ILength
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Length(
            RedBlackTree<IkIndexElement, ILengthParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IkIndexElement, ILengthParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IkIndexElement kIndexElement)
        {
            return this.Value[kIndexElement].Value.Value.Value;
        }
    }
}