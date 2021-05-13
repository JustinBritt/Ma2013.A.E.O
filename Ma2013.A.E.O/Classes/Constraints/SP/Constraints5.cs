namespace Ma2013.A.E.O.Classes.Constraints.SP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    internal sealed class Constraints5 : IConstraints5
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5(
            ImmutableList<IConstraints5ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints5ConstraintElement> Value { get; }
    }
}