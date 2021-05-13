namespace Ma2013.A.E.O.Factories.Indices.Common
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Indices.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.Indices.Common;

    internal sealed class wFactory : IwFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public wFactory()
        {
        }

        public Iw Create(
            ImmutableList<IwIndexElement> value)
        {
            Iw index = null;

            try
            {
                index = new w(
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