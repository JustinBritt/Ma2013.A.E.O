namespace Ma2013.A.E.O.Factories.CrossJoins.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class rkFactory : IrkFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rkFactory()
        {
        }

        public Irk Create(
            ImmutableList<IrkCrossJoinElement> value)
        {
            Irk crossJoin = null;

            try
            {
                crossJoin = new rk(
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