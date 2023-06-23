namespace Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;

    public interface IUB
    {
        RedBlackTree<IpIndexElement, IUBParameterElement> Value { get; }

        int GetElementAtAsint(
            IpIndexElement pIndexElement);
    }
}