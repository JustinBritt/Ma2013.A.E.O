namespace Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    public interface ISPxResultElement
    {
        IpIndexElement pIndexElement { get; }

        IaIndexElement aIndexElement { get; }

        int Value { get; }
    }
}