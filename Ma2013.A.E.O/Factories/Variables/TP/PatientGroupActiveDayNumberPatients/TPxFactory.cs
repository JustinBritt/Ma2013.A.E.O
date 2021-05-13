namespace Ma2013.A.E.O.Factories.Variables.TP.PatientGroupActiveDayNumberPatients
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.PatientGroupActiveDayNumberPatients;

    internal sealed class TPxFactory : ITPxFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPxFactory()
        {
        }

        public ITPx Create(
            VariableCollection<IpIndexElement, IaIndexElement> value)
        {
            ITPx variable = null;

            try
            {
                variable = new TPx(
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