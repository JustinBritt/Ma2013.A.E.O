namespace Ma2013.A.E.O.Factories.Indices.TP
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Indices.TP;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.Indices.TP;
    using Ma2013.A.E.O.InterfacesFactories.Indices.TP;

    internal sealed class rFactory : IrFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rFactory()
        {
        }

        public Ir Create(
            ImmutableList<IrIndexElement> value)
        {
            Ir index = null;

            try
            {
                index = new r(
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