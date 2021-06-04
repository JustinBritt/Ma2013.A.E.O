namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints14ConstraintElementFactory : IConstraints14ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints14ConstraintElementFactory()
        {
        }

        public IConstraints14ConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w,
            Interfaces.Variables.TP.WardDayBedRequirementVariances.IVariance Variance_wd)
        {
            IConstraints14ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints14ConstraintElement(
                    dIndexElement,
                    wIndexElement,
                    Variance_w,
                    Variance_wd);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}