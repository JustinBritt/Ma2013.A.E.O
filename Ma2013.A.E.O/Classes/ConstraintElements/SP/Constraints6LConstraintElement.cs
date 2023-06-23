namespace Ma2013.A.E.O.Classes.ConstraintElements.SP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupNumberPatientBounds;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;

    internal sealed class Constraints6LConstraintElement : IConstraints6LConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6LConstraintElement(
            IpIndexElement pIndexElement,
            Ia a,
            ILB LB,
            ISPx x)
        {
            int LHS = LB.GetElementAtAsint(
                pIndexElement);

            Expression RHS = Expression.Sum(
                a.Value.Values
                .Select(
                   i => x.Value[pIndexElement, i]));

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}