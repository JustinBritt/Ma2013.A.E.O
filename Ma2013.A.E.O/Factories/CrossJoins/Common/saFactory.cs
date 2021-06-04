namespace Ma2013.A.E.O.Factories.CrossJoins.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.Common;

    internal sealed class saFactory : IsaFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public saFactory()
        {
        }

        public Isa Create(
            ImmutableList<IsaCrossJoinElement> value)
        {
            Isa crossJoin = null;

            try
            {
                crossJoin = new sa(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoin;
        }
    }
}