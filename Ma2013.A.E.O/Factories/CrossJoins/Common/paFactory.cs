namespace Ma2013.A.E.O.Factories.CrossJoins.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.Common;

    internal sealed class paFactory : IpaFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public paFactory()
        {
        }

        public Ipa Create(
            ImmutableList<IpaCrossJoinElement> value)
        {
            Ipa crossJoin = null;

            try
            {
                crossJoin = new pa(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return crossJoin;
        }
    }
}