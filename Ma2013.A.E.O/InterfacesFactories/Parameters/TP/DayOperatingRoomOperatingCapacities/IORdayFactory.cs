namespace Ma2013.A.E.O.InterfacesFactories.Parameters.TP.DayOperatingRoomOperatingCapacities
{
    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;

    public interface IORdayFactory
    {
        IORday Create(
            RedBlackTree<IaIndexElement, RedBlackTree<IrIndexElement, IORdayParameterElement>> value);
    }
}