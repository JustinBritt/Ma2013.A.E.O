namespace Ma2013.A.E.O.InterfacesFactories.Parameters.SP.PatientGroupProfits
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;

    public interface IrFactory
    {
        Ir Create(
            RedBlackTree<IpIndexElement, IrParameterElement> value);
    }
}