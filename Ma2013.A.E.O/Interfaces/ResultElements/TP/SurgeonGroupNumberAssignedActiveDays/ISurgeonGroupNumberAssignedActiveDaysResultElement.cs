namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ISurgeonGroupNumberAssignedActiveDaysResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}