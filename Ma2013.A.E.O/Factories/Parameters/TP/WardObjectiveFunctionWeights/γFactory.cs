﻿namespace Ma2013.A.E.O.Factories.Parameters.TP.WardObjectiveFunctionWeights
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.TP.WardObjectiveFunctionWeights;

    internal sealed class γFactory : IγFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public γFactory()
        {
        }

        public Iγ Create(
            RedBlackTree<IwIndexElement, IγParameterElement> value)
        {
            Iγ parameter = null;

            try
            {
                parameter = new γ(
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