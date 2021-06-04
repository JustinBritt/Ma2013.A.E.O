namespace Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;

    internal sealed class SurgeonGroupNumberAssignedActiveDaysResultElementFactory : ISurgeonGroupNumberAssignedActiveDaysResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberAssignedActiveDaysResultElementFactory()
        {
        }

        public ISurgeonGroupNumberAssignedActiveDaysResultElement Create(
            IsIndexElement sIndexElement,
            int value)
        {
            ISurgeonGroupNumberAssignedActiveDaysResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonGroupNumberAssignedActiveDaysResultElement(
                    sIndexElement,
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