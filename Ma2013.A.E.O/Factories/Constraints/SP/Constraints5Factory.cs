namespace Ma2013.A.E.O.Factories.Constraints.SP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Constraints.SP;
    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;
    using Ma2013.A.E.O.InterfacesFactories.Constraints.SP;

    internal sealed class Constraints5Factory : IConstraints5Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5Factory()
        {
        }

        public IConstraints5 Create(
            ImmutableList<IConstraints5ConstraintElement> value)
        {
            IConstraints5 constraint = null;

            try
            {
                constraint = new Constraints5(
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