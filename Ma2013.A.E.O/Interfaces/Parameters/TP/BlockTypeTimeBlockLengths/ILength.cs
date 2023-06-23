namespace Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;

    public interface ILength
    {
        RedBlackTree<IkIndexElement, ILengthParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IkIndexElement kIndexElement);
    }
}