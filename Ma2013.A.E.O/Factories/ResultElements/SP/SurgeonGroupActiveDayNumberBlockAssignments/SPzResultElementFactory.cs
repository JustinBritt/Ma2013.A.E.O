namespace Ma2013.A.E.O.Factories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class SPzResultElementFactory : ISPzResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPzResultElementFactory()
        {
        }

        public ISPzResultElement Create(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            int value)
        {
            ISPzResultElement resultElement = null;

            try
            {
                resultElement = new SPzResultElement(
                    sIndexElement,
                    aIndexElement,
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