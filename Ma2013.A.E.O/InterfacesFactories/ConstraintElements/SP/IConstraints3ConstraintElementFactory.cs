namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupDaySubsetActiveDays;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;

    public interface IConstraints3ConstraintElementFactory
    {
        IConstraints3ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Ipa pa,
            IA A,
            IP P,
            ISPx x,
            ISPy y);
    }
}