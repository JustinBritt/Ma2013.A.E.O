namespace Ma2013.A.E.O.Classes.Constraints.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;
    using Ma2013.A.E.O.Interfaces.Constraints.TP;

    internal sealed class Constraints11 : IConstraints11
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints11(
            ImmutableList<IConstraints11ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints11ConstraintElement> Value { get; }
    }
}