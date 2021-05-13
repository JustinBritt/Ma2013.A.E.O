namespace Ma2013.A.E.O.Classes.Constraints.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    internal sealed class Constraints15 : IConstraints15
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints15(
            ImmutableList<IConstraints15ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints15ConstraintElement> Value { get; }
    }
}