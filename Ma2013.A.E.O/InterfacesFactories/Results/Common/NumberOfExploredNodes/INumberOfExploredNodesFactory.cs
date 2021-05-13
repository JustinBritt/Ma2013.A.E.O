namespace Ma2013.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes
{
    using Ma2013.A.E.O.Interfaces.Results.Common.NumberOfExploredNodes;

    public interface INumberOfExploredNodesFactory
    {
        INumberOfExploredNodes Create(
            long value);
    }
}