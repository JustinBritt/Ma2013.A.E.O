namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;
 
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    internal sealed class Constraints15ConstraintElement : IConstraints15ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints15ConstraintElement(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            Isk sk,
            ILength Length,
            IORday ORday,
            ITPz z)
        {
            Expression LHS = Expression.Sum(
                sk.Value
                .Select(
                    i =>
                    z.Value[i.sIndexElement, aIndexElement, rIndexElement, i.kIndexElement]
                    *
                    (double)Length.GetElementAtAsdecimal(
                        i.kIndexElement)));

            double RHS = (double)ORday.GetElementAtAsdecimal(
                aIndexElement,
                rIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}