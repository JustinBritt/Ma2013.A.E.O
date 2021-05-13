namespace Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ITPxResultElement
    {
        IpIndexElement pIndexElement { get; }

        IaIndexElement aIndexElement { get; }

        int Value { get; }
    }
}