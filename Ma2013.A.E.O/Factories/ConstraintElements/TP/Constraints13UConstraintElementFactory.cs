namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints13UConstraintElementFactory : IConstraints13UConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13UConstraintElementFactory()
        {
        }

        public IConstraints13UConstraintElement Create(
            IdIndexElement dIndexElement,
            IwIndexElement wIndexElement,
            Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w,
            Interfaces.Variables.TP.WardDayBedAvailabilityDeviations.IδPlus δPlus_wd)
        {
            IConstraints13UConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints13UConstraintElement(
                    dIndexElement,
                    wIndexElement,
                    δPlus_w,
                    δPlus_wd);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}