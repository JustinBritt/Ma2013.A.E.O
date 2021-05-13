namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.PatientGroupActiveDayNumberPatients
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;

    public interface ITPxFactory
    {
        ITPx Create(
            VariableCollection<IpIndexElement, IaIndexElement> value);
    }
}