namespace Ma2013.A.E.O.Factories.Variables.TP.WardDayBedRequirementMeans
{
    using System;
  
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementMeans;

    internal sealed class μFactory : IμFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μFactory()
        {
        }

        public Iμ Create(
            VariableCollection<IwIndexElement, IdIndexElement> value)
        {
            Iμ variable = null;

            try
            {
                variable = new μ(
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