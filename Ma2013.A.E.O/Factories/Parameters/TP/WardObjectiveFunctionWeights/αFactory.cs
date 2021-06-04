namespace Ma2013.A.E.O.Factories.Parameters.TP.WardObjectiveFunctionWeights
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class αFactory : IαFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public αFactory()
        {
        }

        public Iα Create(
            ImmutableList<IαParameterElement> value)
        {
            Iα parameter = null;

            try
            {
                parameter = new α(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}