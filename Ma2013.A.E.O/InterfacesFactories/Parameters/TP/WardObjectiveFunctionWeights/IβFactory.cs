namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;

    public interface IβFactory
    {
        Iβ Create(
            RedBlackTree<IwIndexElement, IβParameterElement> value);
    }
}