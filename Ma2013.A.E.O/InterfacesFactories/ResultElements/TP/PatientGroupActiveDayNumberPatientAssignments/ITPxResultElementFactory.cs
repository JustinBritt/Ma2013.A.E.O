namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;

    public interface ITPxResultElementFactory
    {
        ITPxResultElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            int value);
    }
}