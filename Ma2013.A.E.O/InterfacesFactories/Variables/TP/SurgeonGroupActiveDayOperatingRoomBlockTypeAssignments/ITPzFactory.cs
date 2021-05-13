namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    public interface ITPzFactory
    {
        ITPz Create(
            VariableCollection<IsIndexElement, IaIndexElement, IrIndexElement, IkIndexElement> value);
    }
}