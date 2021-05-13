namespace Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP
{
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupDayLengthOfStayProbabilities;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances;

    public interface IConstraints12ConstraintElementFactory
    {
        IConstraints12ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Id d,
            Il l,
            Ipa pa,
            IP P,
            Iprob prob,
            ITPx x,
            IVariance Variance);
    }
}