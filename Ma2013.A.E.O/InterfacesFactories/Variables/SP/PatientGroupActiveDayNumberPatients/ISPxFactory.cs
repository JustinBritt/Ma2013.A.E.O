namespace Ma2013.A.E.O.InterfacesFactories.Variables.SP.PatientGroupActiveDayNumberPatients
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;

    public interface ISPxFactory
    {
        ISPx Create(
            VariableCollection<IpIndexElement, IaIndexElement> value);
    }
}