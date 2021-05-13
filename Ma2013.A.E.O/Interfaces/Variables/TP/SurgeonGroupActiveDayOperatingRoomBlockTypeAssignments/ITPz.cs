namespace Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    public interface ITPz
    {
        VariableCollection<IsIndexElement, IaIndexElement, IrIndexElement, IkIndexElement> Value { get; }

        bool GetElementAt(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement);

        Interfaces.Results.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments.ITPz GetElementsAt(
            ITPzResultElementFactory zResultElementFactory,
            ITPzFactory zFactory,
            Isark sark);
    }
}