namespace Ma2013.A.E.O.InterfacesFactories.Parameters.Common.PatientGroupSurgeryDurations
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;

    public interface IdurFactory
    {
        Idur Create(
            RedBlackTree<IpIndexElement, IdurParameterElement> value);
    }
}