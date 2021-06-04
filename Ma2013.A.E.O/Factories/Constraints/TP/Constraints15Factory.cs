namespace Ma2013.A.E.O.Factories.Constraints.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraints15Factory : IConstraints15Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints15Factory()
        {
        }

        public IConstraints15 Create(
            ImmutableList<IConstraints15ConstraintElement> value)
        {
            IConstraints15 constraint = null;

            try
            {
                constraint = new Constraints15(
                    value);
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