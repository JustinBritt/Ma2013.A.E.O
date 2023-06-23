namespace Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;

    public interface ITHR
    {
        RedBlackTree<IpIndexElement, ITHRParameterElement> Value { get; }

        int GetElementAtAsint(
            IpIndexElement pIndexElement);
    }
}