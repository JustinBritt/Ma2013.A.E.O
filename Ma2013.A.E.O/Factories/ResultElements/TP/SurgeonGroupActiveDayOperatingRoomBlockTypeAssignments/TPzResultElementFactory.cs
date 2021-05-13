namespace Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments
{
    using System;
  
    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.TP;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupActiveDayOperatingRoomBlockTypeAssignments;

    internal sealed class TPzResultElementFactory : ITPzResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPzResultElementFactory()
        {
        }

        public ITPzResultElement Create(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            IrIndexElement rIndexElement,
            IkIndexElement kIndexElement,
            bool value)
        {
            ITPzResultElement resultElement = null;

            try
            {
                resultElement = new TPzResultElement(
                    sIndexElement,
                    aIndexElement,
                    rIndexElement,
                    kIndexElement,
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