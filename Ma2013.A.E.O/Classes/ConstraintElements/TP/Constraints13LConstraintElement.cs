namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;

    internal sealed class Constraints13LConstraintElement : IConstraints13LConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13LConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            ITPy y,
            IδMinus δMinus,
            Iμ μ)
        {
            Expression LHS = 
                -δMinus.Value[wIndexElement, dIndexElement];

            Expression RHS = 
                y.Value[wIndexElement] 
                - 
                μ.Value[wIndexElement, dIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}