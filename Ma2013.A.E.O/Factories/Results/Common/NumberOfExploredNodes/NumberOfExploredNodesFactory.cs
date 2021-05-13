﻿namespace Ma2013.A.E.O.Factories.Results.Common.NumberOfExploredNodes
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.Results.Common.NumberOfExploredNodes;
    using Ma2013.A.E.O.Interfaces.Results.Common.NumberOfExploredNodes;
    using Ma2013.A.E.O.InterfacesFactories.Results.Common.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodesFactory : INumberOfExploredNodesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodesFactory()
        {
        }

        public INumberOfExploredNodes Create(
            long value)
        {
            INumberOfExploredNodes result = null;

            try
            {
                result = new NumberOfExploredNodes(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error("Exception message: " + exception.Message + " and stacktrace " + exception.StackTrace);
            }

            return result;
        }
    }
}