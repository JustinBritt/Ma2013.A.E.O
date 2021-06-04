namespace Ma2013.A.E.O.Factories.Variables.TP.WardDayBedAvailabilityDeviations
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations;

    internal sealed class δPlusFactory : IδPlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public δPlusFactory()
        {
        }

        public IδPlus Create(
            VariableCollection<IwIndexElement, IdIndexElement> value)
        {
            IδPlus variable = null;

            try
            {
                variable = new δPlus(
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