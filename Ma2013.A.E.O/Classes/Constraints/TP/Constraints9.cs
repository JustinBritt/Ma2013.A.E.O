namespace Ma2013.A.E.O.Classes.Constraints.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    internal sealed class Constraints9 : IConstraints9
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9(
            ImmutableList<IConstraints9ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints9ConstraintElement> Value { get; }
    }
}