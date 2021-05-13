namespace Ma2013.A.E.O.Classes.Constraints.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    internal sealed class Constraints13L : IConstraints13L
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints13L(
            ImmutableList<IConstraints13LConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints13LConstraintElement> Value { get; }
    }
}