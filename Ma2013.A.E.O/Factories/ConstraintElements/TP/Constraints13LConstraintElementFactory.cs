namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints13LConstraintElementFactory : IConstraints13LConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13LConstraintElementFactory()
        {
        }

        public IConstraints13LConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            ITPy y,
            IδMinus δMinus,
            Iμ μ)
        {
            IConstraints13LConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints13LConstraintElement(
                    dIndexElement,
                    wIndexElement,
                    y,
                    δMinus,
                    μ);
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