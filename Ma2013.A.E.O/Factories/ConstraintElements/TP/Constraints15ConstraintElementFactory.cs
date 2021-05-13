namespace Ma2013.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.DayOperatingRoomOperatingCapacities;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.BlockTypeTimeBlockLengths;
    using Ma2013.A.E.O.Interfaces.Variables.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints15ConstraintElementFactory : IConstraints15ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints15ConstraintElementFactory()
        {
        }

        public IConstraints15ConstraintElement Create(
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            Isk sk,
            ILength Length,
            IORday ORday,
            ITPz z)
        {
            IConstraints15ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints15ConstraintElement(
                    aIndexElement,
                    rIndexElement,
                    sk,
                    Length,
                    ORday,
                    z);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraintElement;
        }
    }
}