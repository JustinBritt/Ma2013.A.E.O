namespace Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;

    public interface Iα
    {
        RedBlackTree<IwIndexElement, IαParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IwIndexElement wIndexElement);
    }
}