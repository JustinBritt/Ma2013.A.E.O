namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.BlockTypeTimeBlockLengths
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;

    public interface ILengthFactory
    {
        ILength Create(
            RedBlackTree<IkIndexElement, ILengthParameterElement> value);
    }
}