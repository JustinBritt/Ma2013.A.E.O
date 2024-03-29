﻿namespace Ma2013.A.E.O.Factories.Variables.TP.WardDayBedRequirementVariances
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Classes.Variables.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedRequirementVariances;

    internal sealed class VarianceFactory : IVarianceFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public VarianceFactory()
        {
        }

        public IVariance Create(
            VariableCollection<IwIndexElement, IdIndexElement> value)
        {
            IVariance variable = null;

            try
            {
                variable = new Variance(
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