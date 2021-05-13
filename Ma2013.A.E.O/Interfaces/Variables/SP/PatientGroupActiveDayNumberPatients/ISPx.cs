namespace Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.PatientGroupActiveDayNumberPatientAssignments;

    public interface ISPx
    {
        VariableCollection<IpIndexElement, IaIndexElement> Value { get; }

        int GetElementAt(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement);

        Interfaces.Results.SP.PatientGroupActiveDayNumberPatientAssignments.ISPx GetElementsAt(
            ISPxResultElementFactory xResultElementFactory,
            ISPxFactory xFactory,
            Ipa pa);
    }
}