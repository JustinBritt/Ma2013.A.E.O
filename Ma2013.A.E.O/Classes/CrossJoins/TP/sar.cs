namespace Ma2013.A.E.O.Classes.CrossJoins.TP
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;

    internal sealed class sar : Isar
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sar(
            ImmutableList<IsarCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsarCrossJoinElement> Value { get; }
    }
}