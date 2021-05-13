namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;

    public interface ISPxResultElementFactory
    {
        ISPxResultElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            int value);
    }
}