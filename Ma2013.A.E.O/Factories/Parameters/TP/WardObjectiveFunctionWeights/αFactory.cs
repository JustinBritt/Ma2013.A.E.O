namespace Ma2013.A.E.O.Factories.Parameters.TP.WardObjectiveFunctionWeights
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
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
            RedBlackTree<IwIndexElement, IαParameterElement> value)
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