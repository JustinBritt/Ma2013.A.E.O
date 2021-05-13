namespace Ma2013.A.E.O.Interfaces.Calculations.TP.NumberPatients
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Results.TP.NumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.NumberPatients;

    public interface INumberPatientsCalculation
    {
        INumberPatients Calculate(
            INumberPatientsFactory numberPatientsFactory,
            Ipa pa,
            ITPx x);
    }
}