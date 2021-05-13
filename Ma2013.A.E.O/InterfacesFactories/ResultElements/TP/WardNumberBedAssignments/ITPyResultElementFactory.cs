namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberBedAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;

    public interface ITPyResultElementFactory
    {
        ITPyResultElement Create(
            IwIndexElement wIndexElement,
            int value);
    }
}