namespace Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    public interface ISPz
    {
        VariableCollection<IsIndexElement, IaIndexElement> Value { get; }

        int GetElementAt(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement);

        Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments.ISPz GetElementsAt(
            ISPzResultElementFactory zResultElementFactory,
            ISPzFactory zFactory,
            Isa sa);
    }
}