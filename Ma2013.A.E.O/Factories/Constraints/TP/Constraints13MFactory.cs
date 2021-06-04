namespace Ma2013.A.E.O.Factories.Constraints.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.TP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.TP;

    internal sealed class Constraints13MFactory : IConstraints13MFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13MFactory()
        {
        }

        public IConstraints13M Create(
            ImmutableList<IConstraints13MConstraintElement> value)
        {
            IConstraints13M constraint = null;

            try
            {
                constraint = new Constraints13M(
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