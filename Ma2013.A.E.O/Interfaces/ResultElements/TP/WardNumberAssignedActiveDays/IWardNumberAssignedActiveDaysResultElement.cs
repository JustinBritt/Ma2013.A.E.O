namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface IWardNumberAssignedActiveDaysResultElement
    {
        IwIndexElement wIndexElement { get; }

        int Value { get; }
    }
}