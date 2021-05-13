namespace Ma2013.A.E.O.Factories.Parameters.TP.WardObjectiveFunctionWeights
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class βFactory : IβFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public βFactory()
        {
        }

        public Iβ Create(
            ImmutableList<IβParameterElement> value)
        {
            Iβ parameter = null;

            try
            {
                parameter = new β(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return parameter;
        }
    }
}