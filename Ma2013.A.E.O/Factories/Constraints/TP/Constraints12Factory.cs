namespace Ma2013.A.E.O.Factories.Constraints.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraints12Factory : IConstraints12Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints12Factory()
        {
        }

        public IConstraints12 Create(
            ImmutableList<IConstraints12ConstraintElement> value)
        {
            IConstraints12 constraint = null;

            try
            {
                constraint = new Constraints12(
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