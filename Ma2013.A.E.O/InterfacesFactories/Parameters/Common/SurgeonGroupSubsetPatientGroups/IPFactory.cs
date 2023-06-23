namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.SurgeonGroupSubsetPatientGroups
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;

    public interface IPFactory
    {
        IP Create(
            RedBlackTree<IsIndexElement, IPParameterElement> value);
    }
}