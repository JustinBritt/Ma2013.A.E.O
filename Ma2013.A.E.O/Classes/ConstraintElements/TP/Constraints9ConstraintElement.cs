namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.PatientGroupThroughputs;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;

    internal sealed class Constraints9ConstraintElement : IConstraints9ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElement(
            IpIndexElement pIndexElement,
            Ia a,
            ITHR THR,
            ITPx x)
        {
            Expression LHS = Expression.Sum(
                a.Value.Values
                .Select(
                   i => x.Value[pIndexElement, i]));

            int RHS = THR.GetElementAtAsint(
                pIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}