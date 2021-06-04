namespace Ma2013.A.E.O.Factories.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.InterfacesFactories.Variables.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    internal sealed class SPzFactory : ISPzFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPzFactory()
        {
        }

        public ISPz Create(
            VariableCollection<IsIndexElement, IaIndexElement> value)
        {
            ISPz variable = null;

            try
            {
                variable = new SPz(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}