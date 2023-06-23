namespace Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.PatientGroupSurgeryDurations;

    public interface Idur
    {
        RedBlackTree<IpIndexElement, IdurParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IpIndexElement pIndexElement);
    }
}