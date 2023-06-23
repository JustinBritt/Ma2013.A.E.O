namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupNumberPatientBounds
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;

    public interface IUBFactory
    {
        IUB Create(
            RedBlackTree<IpIndexElement, IUBParameterElement> value);
    }
}