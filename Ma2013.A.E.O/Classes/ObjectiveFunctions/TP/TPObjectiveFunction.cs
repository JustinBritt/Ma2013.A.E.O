namespace Ma2013.A.E.O.Classes.ObjectiveFunctions.TP
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ObjectiveFunctions.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardSpareBeds;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class TPObjectiveFunction : ITPObjectiveFunction
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPObjectiveFunction(
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
            Expression expression = Expression.Sum(
                w.Value
                .Select(
                    i =>
                    (double)α.GetElementAtAsdecimal(
                        i)
                    *
                    Expression.Sum(
                        d.Value
                        .Select(
                            j => 
                            δMinus.Value[i, j]))
                    +
                    (double)β.GetElementAtAsdecimal(
                        i)
                    *
                    δPlus_w.Value[i]
                    +
                    (double)γ.GetElementAtAsdecimal(
                        i)
                    *
                    Variance_w.Value[i]));

            Objective objective = objectiveFactory.Create(
                expression,
                ObjectiveSense.Minimize);

            this.Value = objective;
        }

        public Objective Value { get; }
    }
}