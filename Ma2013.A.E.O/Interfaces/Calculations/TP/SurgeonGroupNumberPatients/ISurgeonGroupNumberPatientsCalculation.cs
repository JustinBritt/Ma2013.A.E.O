namespace Ma2013.A.E.O.Interfaces.Calculations.TP.SurgeonGroupNumberPatients
{
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberPatients;

    public interface ISurgeonGroupNumberPatientsCalculation
    {
        ISurgeonGroupNumberPatients Calculate(
            ISurgeonGroupNumberPatientsResultElementFactory surgeonGroupNumberPatientsResultElementFactory,
            ISurgeonGroupNumberPatientsFactory surgeonGroupNumberPatientsFactory,
            ISurgeonGroupNumberPatientsResultElementCalculation surgeonGroupNumberPatientsResultElementCalculation,
            Is s,
            Ipa pa,
            IP P,
            ITPx x);
    }
}