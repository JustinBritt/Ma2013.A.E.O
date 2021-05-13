namespace Ma2013.A.E.O.Factories.Constraints.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraints9Factory : IConstraints9Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9Factory()
        {
        }

        public IConstraints9 Create(
            ImmutableList<IConstraints9ConstraintElement> value)
        {
            IConstraints9 constraint = null;

            try
            {
                constraint = new Constraints9(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return constraint;
        }
    }
}