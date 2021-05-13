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

    internal sealed class Constraints6UConstraintElement : IConstraints6UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6UConstraintElement(
            IpIndexElement pIndexElement,
            Ia a,
            IUB UB,
            ISPx x)
        {
            Expression LHS = Expression.Sum(
                a.Value
                .Select(
                   i => x.Value[pIndexElement, i]));

            int RHS = UB.GetElementAtAsint(
                pIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}