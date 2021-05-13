namespace Ma2013.A.E.O.Factories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;

    internal sealed class TPxResultElementFactory : ITPxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxResultElementFactory()
        {
        }

        public ITPxResultElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            int value)
        {
            ITPxResultElement resultElement = null;

            try
            {
                resultElement = new TPxResultElement(
                    pIndexElement,
                    aIndexElement,
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