namespace Ma2013.A.E.O.InterfacesFactories.Variables.SP.WardNumberBedAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;

    public interface ISPyFactory
    {
        ISPy Create(
            VariableCollection<IwIndexElement> value);
    }
}