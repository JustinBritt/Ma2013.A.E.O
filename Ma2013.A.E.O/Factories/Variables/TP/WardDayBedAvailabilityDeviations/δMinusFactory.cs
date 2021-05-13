namespace Ma2013.A.E.O.Factories.Variables.TP.WardDayBedAvailabilityDeviations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δMinusFactory : IδMinusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δMinusFactory()
        {
        }

        public IδMinus Create(
            VariableCollection<IwIndexElement, IdIndexElement> value)
        {
            IδMinus variable = null;

            try
            {
                variable = new δMinus(
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