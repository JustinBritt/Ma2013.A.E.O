namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.WardNumberBedAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;

    public interface ISPyResultElementFactory
    {
        ISPyResultElement Create(
            IwIndexElement wIndexElement,
            int value);
    }
}