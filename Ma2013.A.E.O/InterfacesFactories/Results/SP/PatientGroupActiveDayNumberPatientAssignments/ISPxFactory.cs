namespace Ma2013.A.E.O.InterfacesFactories.Results.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.PatientGroupActiveDayNumberPatientAssignments;

    public interface ISPxFactory
    {
        ISPx Create(
            ImmutableList<ISPxResultElement> value);
    }
}