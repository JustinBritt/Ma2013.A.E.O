namespace Ma2013.A.E.O.Classes.ConstraintElements.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class Constraints4ConstraintElement : IConstraints4ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElement(
            IaIndexElement aIndexElement,
            Is s,
            IBLOCKS BLOCKS,
            ISPz z)
        {
            Expression LHS = Expression.Sum(
                s.Value.Values
                .Select(
                   i => z.Value[i, aIndexElement]));

            int RHS = BLOCKS.Value.Value.Value;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}