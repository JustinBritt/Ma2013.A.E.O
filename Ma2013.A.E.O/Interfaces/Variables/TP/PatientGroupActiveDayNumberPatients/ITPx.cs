namespace Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.PatientGroupActiveDayNumberPatientAssignments;

    public interface ITPx
    {
        VariableCollection<IpIndexElement, IaIndexElement> Value { get; }

        int GetElementAt(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement);

        Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments.ITPx GetElementsAt(
            ITPxResultElementFactory xResultElementFactory,
            ITPxFactory xFactory,
            Ipa pa);
    }
}