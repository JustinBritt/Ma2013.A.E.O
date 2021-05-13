namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class Constraints14ConstraintElement : IConstraints14ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints14ConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w,
            Interfaces.Variables.TP.WardDayBedRequirementVariances.IVariance Variance_wd)
        {
            Expression LHS =
                Variance_wd.Value[wIndexElement, dIndexElement];

            Expression RHS =
                Variance_w.Value[wIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}