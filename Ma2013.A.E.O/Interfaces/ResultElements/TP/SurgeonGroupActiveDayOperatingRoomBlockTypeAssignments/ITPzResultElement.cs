namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;

    public interface ITPzResultElement
    {
        IsIndexElement sIndexElement { get; }

        IaIndexElement aIndexElement { get; }

        IrIndexElement rIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        bool Value { get; }
    }
}