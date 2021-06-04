namespace Ma2013.A.E.O.Factories.ObjectiveFunctions.SP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.ObjectiveFunctions.SP;
    using Ma2013.A.E.O.Interfaces.Parameters.SP.PatientGroupProfits;
    using Ma2013.A.E.O.Interfaces.Variables.SP.PatientGroupActiveDayNumberPatients;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.SP;

    internal sealed class SPObjectiveFunctionFactory : ISPObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPObjectiveFunctionFactory()
        {
        }

        public ISPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Ipa pa,
            Ir r,
            ISPx x)
        {
            ISPObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new SPObjectiveFunction(
                    objectiveFactory,
                    pa,
                    r,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}