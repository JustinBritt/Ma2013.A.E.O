﻿namespace Ma2013.A.E.O.Factories.Parameters.Common.WardSubsetPatientGroups
{
    using System;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Ma2013.A.E.O.Classes.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ParameterElements.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.Interfaces.Parameters.Common.WardSubsetPatientGroups;
    using Ma2013.A.E.O.InterfacesFactories.Parameters.Common.WardSubsetPatientGroups;

    internal sealed class PFactory : IPFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PFactory()
        {
        }

        public IP Create(
            RedBlackTree<IwIndexElement, IPParameterElement> value)
        {
            IP parameter = null;

            try
            {
                parameter = new P(
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