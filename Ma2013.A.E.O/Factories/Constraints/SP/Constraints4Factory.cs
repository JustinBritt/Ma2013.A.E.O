namespace Ma2013.A.E.O.Factories.Constraints.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraints4Factory : IConstraints4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4Factory()
        {
        }

        public IConstraints4 Create(
            ImmutableList<IConstraints4ConstraintElement> value)
        {
            IConstraints4 constraint = null;

            try
            {
                constraint = new Constraints4(
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