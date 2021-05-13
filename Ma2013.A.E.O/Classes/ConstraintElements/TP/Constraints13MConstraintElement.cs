namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    internal sealed class Constraints13MConstraintElement : IConstraints13MConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13MConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            ITPy y,
            IδPlus δPlus,
            Iμ μ)
        {
            Expression LHS =
                y.Value[wIndexElement]
                -
                μ.Value[wIndexElement, dIndexElement];

            Expression RHS = δPlus.Value[wIndexElement, dIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}