namespace Ma2013.A.E.O.Factories.Constraints.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraints16Factory : IConstraints16Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints16Factory()
        {
        }

        public IConstraints16 Create(
            ImmutableList<IConstraints16ConstraintElement> value)
        {
            IConstraints16 constraint = null;

            try
            {
                constraint = new Constraints16(
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