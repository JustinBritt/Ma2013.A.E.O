namespace Ma2013.A.E.O.Factories.ResultElements.TP.SurgeonGroupNumberPatients
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberPatients;

    internal sealed class SurgeonGroupNumberPatientsResultElementFactory : ISurgeonGroupNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonGroupNumberPatientsResultElementFactory()
        {
        }

        public ISurgeonGroupNumberPatientsResultElement Create(
            IsIndexElement sIndexElement,
            int value)
        {
            ISurgeonGroupNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonGroupNumberPatientsResultElement(
                    sIndexElement,
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