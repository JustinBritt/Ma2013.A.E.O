namespace Ma2013.A.E.O.Classes.Constraints.SP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    internal sealed class Constraints3 : IConstraints3
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3(
            ImmutableList<IConstraints3ConstraintElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IConstraints3ConstraintElement> Value { get; }
    }
}