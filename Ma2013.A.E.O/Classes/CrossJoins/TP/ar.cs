namespace Ma2013.A.E.O.Classes.CrossJoins.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;

    internal sealed class ar : Iar
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ar(
            ImmutableList<IarCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IarCrossJoinElement> Value { get; }
    }
}