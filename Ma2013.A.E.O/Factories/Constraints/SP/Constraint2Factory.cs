namespace Ma2013.A.E.O.Factories.Constraints.SP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.NumberBeds;
    using Ma2013.A.E.O.Interfaces.Variables.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraint2Factory : IConstraint2Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraint2Factory()
        {
        }

        public IConstraint2 Create(
            Iw w,
            IBEDS BEDS,
            ISPy y)
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
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraint;
        }
    }
}