namespace Ma2013.A.E.O.Factories.Constraints.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraint2Factory : IConstraint2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint2Factory()
        {
        }

        public IConstraint2 Create(
            Iw w,
            IBEDS BEDS,
            ITPy y)
        {
            IConstraint2 constraint = null;

            try
            {
                constraint = new Constraint2(
                    w,
                    BEDS,
                    y);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraint;
        }
    }
}