namespace Ma2013.A.E.O.Factories.CrossJoins.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class arFactory : IarFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public arFactory()
        {
        }

        public Iar Create(
            ImmutableList<IarCrossJoinElement> value)
        {
            Iar crossJoin = null;

            try
            {
                crossJoin = new ar(
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