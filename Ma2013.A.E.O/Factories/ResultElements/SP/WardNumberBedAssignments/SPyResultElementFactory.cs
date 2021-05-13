namespace Ma2013.A.E.O.Factories.ResultElements.SP.WardNumberBedAssignments
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.WardNumberBedAssignments;

    internal sealed class SPyResultElementFactory : ISPyResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPyResultElementFactory()
        {
        }

        public ISPyResultElement Create(
            IwIndexElement wIndexElement,
            int value)
        {
            ISPyResultElement resultElement = null;

            try
            {
                resultElement = new SPyResultElement(
                    wIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return resultElement;
        }
    }
}