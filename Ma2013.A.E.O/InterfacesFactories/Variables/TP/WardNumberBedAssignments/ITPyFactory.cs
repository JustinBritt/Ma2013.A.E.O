namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardNumberBedAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    public interface ITPyFactory
    {
        ITPy Create(
            VariableCollection<IwIndexElement> value);
    }
}