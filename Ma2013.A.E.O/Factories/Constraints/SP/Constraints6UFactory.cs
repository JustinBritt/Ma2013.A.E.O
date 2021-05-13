namespace Ma2013.A.E.O.Factories.Constraints.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraints6UFactory : IConstraints6UFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6UFactory()
        {
        }

        public IConstraints6U Create(
            ImmutableList<IConstraints6UConstraintElement> value)
        {
            IConstraints6U constraint = null;

            try
            {
                constraint = new Constraints6U(
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