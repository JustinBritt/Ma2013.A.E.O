namespace Ma2013.A.E.O.Classes.Constraints.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    internal sealed class Constraints13M : IConstraints13M
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13M(
            ImmutableList<IConstraints13MConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints13MConstraintElement> Value { get; }
    }
}