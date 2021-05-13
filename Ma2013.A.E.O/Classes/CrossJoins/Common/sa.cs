namespace Ma2013.A.E.O.Classes.CrossJoins.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;

    internal sealed class sa : Isa
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sa(
            ImmutableList<IsaCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsaCrossJoinElement> Value { get; }
    }
}