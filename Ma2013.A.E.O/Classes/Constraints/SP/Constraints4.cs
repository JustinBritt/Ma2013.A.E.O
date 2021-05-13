namespace Ma2013.A.E.O.Classes.Constraints.SP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    internal sealed class Constraints4 : IConstraints4
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4(
            ImmutableList<IConstraints4ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints4ConstraintElement> Value { get; }
    }
}