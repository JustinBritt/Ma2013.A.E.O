namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ITPyResultElement
    {
        IwIndexElement wIndexElement { get; }

        int Value { get; }
    }
}