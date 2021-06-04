namespace Ma2013.A.E.O.Factories.Results.TP.WardNumberBedAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberBedAssignments;

    internal sealed class TPyFactory : ITPyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPyFactory()
        {
        }

        public ITPy Create(
            ImmutableList<ITPyResultElement> value)
        {
            ITPy result = null;

            try
            {
                result = new TPy(
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