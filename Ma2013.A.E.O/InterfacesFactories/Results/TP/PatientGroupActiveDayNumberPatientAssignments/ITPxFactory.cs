namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;

    public interface ITPxFactory
    {
        ITPx Create(
            ImmutableList<ITPxResultElement> value);
    }
}