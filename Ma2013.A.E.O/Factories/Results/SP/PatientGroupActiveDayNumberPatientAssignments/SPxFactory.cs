namespace Ma2013.A.E.O.Factories.Results.SP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.SP.PatientGroupActiveDayNumberPatientAssignments;

    internal sealed class SPxFactory : ISPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxFactory()
        {
        }

        public ISPx Create(
            ImmutableList<ISPxResultElement> value)
        {
            ISPx result = null;

            try
            {
                result = new SPx(
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