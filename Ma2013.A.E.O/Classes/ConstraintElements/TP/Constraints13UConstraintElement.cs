namespace Ma2013.A.E.O.Classes.ConstraintElements.TP
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;

    internal sealed class Constraints13UConstraintElement : IConstraints13UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13UConstraintElement(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w,
            Interfaces.Variables.TP.WardDayBedAvailabilityDeviations.IδPlus δPlus_wd)
        {
            Expression LHS = δPlus_wd.Value[wIndexElement, dIndexElement];

            Expression RHS = δPlus_w.Value[wIndexElement];

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}