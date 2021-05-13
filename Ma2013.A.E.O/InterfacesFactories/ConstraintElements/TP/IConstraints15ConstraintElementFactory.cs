namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    public interface IConstraints15ConstraintElementFactory
    {
        IConstraints15ConstraintElement Create(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            Isk sk,
            ILength Length,
            IORday ORday,
            ITPz z);
    }
}