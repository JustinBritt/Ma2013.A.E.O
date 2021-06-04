namespace Ma2013.A.E.O.Factories.ObjectiveFunctions.TP
{
    using System;

    using log4net;

    using Ma2013.A.E.O.Classes.ObjectiveFunctions.TP;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ObjectiveFunctions.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;
    using Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.TP;

    internal sealed class TPObjectiveFunctionFactory : ITPObjectiveFunctionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPObjectiveFunctionFactory()
        {
        }

        public ITPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Id d,
            Iw w,
            Iα α,
            Iβ β,
            Iγ γ,
            IδMinus δMinus,
            Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w,
            Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w)
        {
            ITPObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new TPObjectiveFunction(
                    objectiveFactory,
                    d,
                    w,
                    α,
                    β,
                    γ,
                    δMinus,
                    δPlus_w,
                    Variance_w);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return objectiveFunction;
        }
    }
}