namespace Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberPatients
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;

    public interface ISurgeonGroupNumberPatientsResultElementCalculation
    {
        ISurgeonGroupNumberPatientsResultElement Calculate(
            ISurgeonGroupNumberPatientsResultElementFactory surgeonGroupNumberPatientsResultElementFactory,
            IsIndexElement sIndexElement,
            Ipa pa,
            IP P,
            ITPx x);
    }
}