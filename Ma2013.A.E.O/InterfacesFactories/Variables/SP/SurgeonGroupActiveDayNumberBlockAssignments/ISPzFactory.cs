namespace Ma2013.A.E.O.InterfacesFactories.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    public interface ISPzFactory
    {
        ISPz Create(
            VariableCollection<IsIndexElement, IaIndexElement> value);
    }
}