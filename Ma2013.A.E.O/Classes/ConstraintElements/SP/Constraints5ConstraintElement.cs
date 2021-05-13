namespace Ma2013.A.E.O.Classes.ConstraintElements.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.TimeBlockLength;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class Constraints5ConstraintElement : IConstraints5ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5ConstraintElement(
            IaIndexElement aIndexElement,
            IsIndexElement sIndexElement,
            Ip p,
            Idur dur,
            ILENGTH LENGTH,
            IP P,
            ISPx x,
            ISPz z)
        {
            Expression LHS = Expression.Sum(
                p.Value
                .Where(
                    i =>
                    P.IsThereElementAt(
                        sIndexElement,
                        i))
                .Select(
                    i =>
                    (double)dur.GetElementAtAsdecimal(
                        i)
                    *
                    x.Value[i, aIndexElement]));

            Expression RHS =
                z.Value[sIndexElement, aIndexElement]
                *
                (double)LENGTH.Value.Value.Value;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}