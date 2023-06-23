namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;

    public interface IPFactory
    {
        IP Create(
            RedBlackTree<IwIndexElement, IPParameterElement> value);
    }
}