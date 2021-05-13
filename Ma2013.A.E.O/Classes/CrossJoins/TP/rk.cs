namespace Ma2013.A.E.O.Classes.CrossJoins.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;

    internal sealed class rk : Irk
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rk(
            ImmutableList<IrkCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IrkCrossJoinElement> Value { get; }
    }
}