namespace Ma2013.A.E.O.Factories.CrossJoins.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class sarFactory : IsarFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sarFactory()
        {
        }

        public Isar Create(
            ImmutableList<IsarCrossJoinElement> value)
        {
            Isar crossJoin = null;

            try
            {
                crossJoin = new sar(
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