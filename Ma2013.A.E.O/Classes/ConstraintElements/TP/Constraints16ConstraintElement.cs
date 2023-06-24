namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;
  
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.PatientGroupSurgeryDurations;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.SurgeonGroupSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    internal sealed class Constraints16ConstraintElement : IConstraints16ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints16ConstraintElement(
            IaIndexElement aIndexElement,
            IsIndexElement sIndexElement,
            Ip p,
            Irk rk,
            Idur dur,
            ILength Length,
            IP P,
            ITPx x,
            ITPz z)
        {
            Expression LHS = Expression.Sum(
                p.Value.Values
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

            Expression RHS = Expression.Sum(
                rk.Value
                .Select(
                    i =>
                    z.Value[sIndexElement, aIndexElement, i.rIndexElement, i.kIndexElement]
                    *
                    (double)Length.GetElementAtAsdecimal(
                        i.kIndexElement)));

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}