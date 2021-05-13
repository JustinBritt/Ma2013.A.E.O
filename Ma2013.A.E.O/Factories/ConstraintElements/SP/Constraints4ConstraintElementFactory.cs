namespace Ma2013.A.E.O.Factories.ConstraintElements.SP
{
    using System;
 
    using log4net;

    using Ma2013.A.E.O.Classes.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.NumberBlocks;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ConstraintElements.SP;

    internal sealed class Constraints4ConstraintElementFactory : IConstraints4ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElementFactory()
        {
        }

        public IConstraints4ConstraintElement Create(
            IaIndexElement aIndexElement,
            Is s,
            IBLOCKS BLOCKS,
            ISPz z)
        {
            IConstraints4ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints4ConstraintElement(
                    aIndexElement,
                    s,
                    BLOCKS,
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