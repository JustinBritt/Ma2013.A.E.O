namespace Ma2013.A.E.O.Classes.Constraints.SP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    internal sealed class Constraints6U : IConstraints6U
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6U(
            ImmutableList<IConstraints6UConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints6UConstraintElement> Value { get; }
    }
}