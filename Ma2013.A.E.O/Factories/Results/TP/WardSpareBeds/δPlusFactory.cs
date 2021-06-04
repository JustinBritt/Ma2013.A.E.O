namespace Ma2013.A.E.O.Factories.Results.TP.WardSpareBeds
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardSpareBeds;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds;

    internal sealed class δPlusFactory : IδPlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlusFactory()
        {
        }

        public IδPlus Create(
            ImmutableList<IδPlusResultElement> value)
        {
            IδPlus result = null;

            try
            {
                result = new δPlus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}