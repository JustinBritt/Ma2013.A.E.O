namespace Ma2013.A.E.O.Factories.Variables.SP.PatientGroupActiveDayNumberPatients
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.PatientGroupActiveDayNumberPatients;

    internal sealed class SPxFactory : ISPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPxFactory()
        {
        }

        public ISPx Create(
            VariableCollection<IpIndexElement, IaIndexElement> value)
        {
            ISPx variable = null;

            try
            {
                variable = new SPx(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return variable;
        }
    }
}