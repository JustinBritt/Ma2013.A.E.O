namespace Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.WardNumberBedAssignments;

    public interface ISPy
    {
        VariableCollection<IwIndexElement> Value { get; }

        int GetElementAt(
            IwIndexElement wIndexElement);

        Interfaces.Results.SP.WardNumberBedAssignments.ISPy GetElementsAt(
            ISPyResultElementFactory yResultElementFactory,
            ISPyFactory yFactory,
            Iw w);
    }
}