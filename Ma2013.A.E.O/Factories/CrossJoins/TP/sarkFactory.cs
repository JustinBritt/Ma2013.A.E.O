namespace Ma2013.A.E.O.Factories.CrossJoins.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.CrossJoins.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;
    using Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP;

    internal sealed class sarkFactory : IsarkFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public sarkFactory()
        {
        }

        public Isark Create(
            ImmutableList<IsarkCrossJoinElement> value)
        {
            Isark crossJoin = null;

            try
            {
                crossJoin = new sark(
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