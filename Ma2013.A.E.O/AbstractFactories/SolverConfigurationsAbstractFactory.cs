﻿namespace Ma2013.A.E.O.AbstractFactories
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Factories.SolverConfigurations;
    using Ma2013.A.E.O.InterfacesAbstractFactories;
    using Ma2013.A.E.O.InterfacesFactories.SolverConfigurations;

    internal sealed class SolverConfigurationsAbstractFactory : ISolverConfigurationsAbstractFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfigurationsAbstractFactory()
        {
        }

        public ISolverConfigurationFactory CreateSolverConfigurationFactory()
        {
            ISolverConfigurationFactory factory = null;

            try
            {
                factory = new SolverConfigurationFactory();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return factory;
        }
    }
}