namespace Ma2013.A.E.O.Factories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;

    internal sealed class SPxResultElementFactory : ISPxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxResultElementFactory()
        {
        }

        public ISPxResultElement Create(
            IpIndexElement pIndexElement,
            IaIndexElement aIndexElement,
            int value)
        {
            ISPxResultElement resultElement = null;

            try
            {
                resultElement = new SPxResultElement(
                    pIndexElement,
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