namespace Ma2013.A.E.O.Factories.Indices.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Indices.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class kFactory : IkFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kFactory()
        {
        }

        public Ik Create(
            ImmutableList<IkIndexElement> value)
        {
            Ik index = null;

            try
            {
                index = new k(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return index;
        }
    }
}