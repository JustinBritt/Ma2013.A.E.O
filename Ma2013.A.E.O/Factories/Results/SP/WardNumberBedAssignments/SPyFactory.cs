namespace Ma2013.A.E.O.Factories.Results.SP.WardNumberBedAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.WardNumberBedAssignments;

    internal sealed class SPyFactory : ISPyFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPyFactory()
        {
        }

        public ISPy Create(
            ImmutableList<ISPyResultElement> value)
        {
            ISPy result = null;

            try
            {
                result = new SPy(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}