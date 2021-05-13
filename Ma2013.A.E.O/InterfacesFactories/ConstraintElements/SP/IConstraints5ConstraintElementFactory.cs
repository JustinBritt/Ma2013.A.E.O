namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    public interface IConstraints5ConstraintElementFactory
    {
        IConstraints5ConstraintElement Create(
            IaIndexElement aIndexElement,
            IsIndexElement sIndexElement,
            Ip p,
            Idur dur,
            ILENGTH LENGTH,
            IP P,
            ISPx x,
            ISPz z);
    }
}