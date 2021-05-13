namespace Ma2013.A.E.O.Classes.Constraints.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.Constraints.SP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;

    internal sealed class Constraint2 : IConstraint2
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint2(
            Iw w,
            IBEDS BEDS,
            ISPy y)
        {
            Expression LHS = Expression.Sum(
                w.Value
                .Select(
                   i => y.Value[i]));

            int RHS = BEDS.Value.Value.Value;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}