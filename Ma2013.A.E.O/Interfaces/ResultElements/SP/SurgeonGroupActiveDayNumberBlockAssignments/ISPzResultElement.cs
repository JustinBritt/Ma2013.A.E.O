namespace Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ISPzResultElement
    {
        IsIndexElement sIndexElement { get; }

        IaIndexElement aIndexElement { get; }

        int Value { get; }
    }
}