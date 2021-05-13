namespace Ma2013.A.E.O.Factories.Results.TP.PatientGroupActiveDayNumberPatientAssignments
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.PatientGroupActiveDayNumberPatientAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.PatientGroupActiveDayNumberPatientAssignments;

    internal sealed class TPxFactory : ITPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxFactory()
        {
        }

        public ITPx Create(
            ImmutableList<ITPxResultElement> value)
        {
            ITPx result = null;

            try
            {
                result = new TPx(
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