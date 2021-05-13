namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    public interface ITPzResultElementFactory
    {
        ITPzResultElement Create(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement,
            bool value);
    }
}