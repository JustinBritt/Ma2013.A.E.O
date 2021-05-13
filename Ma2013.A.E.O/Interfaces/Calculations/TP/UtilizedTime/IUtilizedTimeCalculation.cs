namespace Ma2013.A.E.O.Interfaces.Calculations.TP.UtilizedTime
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.UtilizedTime;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.UtilizedTime;

    public interface IUtilizedTimeCalculation
    {
        IUtilizedTime Calculate(
            IUtilizedTimeFactory utilizedTimeFactory,
            Ipa pa,
            Idur dur,
            ITPx x);
    }
}