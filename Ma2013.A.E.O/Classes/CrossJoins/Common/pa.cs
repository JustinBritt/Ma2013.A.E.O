namespace Ma2013.A.E.O.Classes.CrossJoins.Common
{
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;

    internal sealed class pa : Ipa
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pa(
            ImmutableList<IpaCrossJoinElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IpaCrossJoinElement> Value { get; }
    }
}