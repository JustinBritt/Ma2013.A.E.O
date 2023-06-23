namespace Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.SurgeonGroupSubsetPatientGroups;

    public interface IP
    {
        RedBlackTree<IsIndexElement, IPParameterElement> Value { get; }

        bool IsThereElementAt(
            IsIndexElement sIndexElement,
            IpIndexElement pIndexElement);
    }
}