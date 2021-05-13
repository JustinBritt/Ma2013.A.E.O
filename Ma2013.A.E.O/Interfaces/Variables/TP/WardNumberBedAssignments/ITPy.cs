namespace Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberBedAssignments;

    public interface ITPy
    {
        VariableCollection<IwIndexElement> Value { get; }

        int GetElementAt(
            IwIndexElement wIndexElement);

        Interfaces.Results.TP.WardNumberBedAssignments.ITPy GetElementsAt(
            ITPyResultElementFactory yResultElementFactory,
            ITPyFactory yFactory,
            Iw w);
    }
}