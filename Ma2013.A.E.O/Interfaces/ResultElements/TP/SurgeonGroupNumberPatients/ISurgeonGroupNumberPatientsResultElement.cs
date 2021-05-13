namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ISurgeonGroupNumberPatientsResultElement
    {
        IsIndexElement sIndexElement { get; }

        int Value { get; }
    }
}