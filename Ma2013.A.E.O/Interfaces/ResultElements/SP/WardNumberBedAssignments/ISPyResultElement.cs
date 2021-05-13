namespace Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ISPyResultElement
    {
        IwIndexElement wIndexElement { get; }

        int Value { get; }
    }
}