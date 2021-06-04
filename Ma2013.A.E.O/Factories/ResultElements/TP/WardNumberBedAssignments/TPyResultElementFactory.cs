namespace Ma2013.A.E.O.Factories.ResultElements.TP.WardNumberBedAssignments
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberBedAssignments;

    internal sealed class TPyResultElementFactory : ITPyResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPyResultElementFactory()
        {
        }

        public ITPyResultElement Create(
            IwIndexElement wIndexElement,
            int value)
        {
            ITPyResultElement resultElement = null;

            try
            {
                resultElement = new TPyResultElement(
                    wIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}