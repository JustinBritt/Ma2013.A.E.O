namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.PatientGroupThroughputs
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;

    public interface ITHRFactory
    {
        ITHR Create(
            RedBlackTree<IpIndexElement, ITHRParameterElement> value);
    }
}