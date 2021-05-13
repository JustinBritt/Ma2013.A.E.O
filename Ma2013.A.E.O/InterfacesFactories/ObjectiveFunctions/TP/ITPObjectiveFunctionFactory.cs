namespace Ma2013.A.E.O.InterfacesFactories.ObjectiveFunctions.TP
{
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.Interfaces.ObjectiveFunctions.TP;
    using Ma2013.A.E.O.Interfaces.Parameters.TP.WardObjectiveFunctionWeights;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    public interface ITPObjectiveFunctionFactory
    {
        ITPObjectiveFunction Create(
            IObjectiveFactory objectiveFactory,
            Id d,
            Iw w,
            Iα α,
            Iβ β,
            Iγ γ,
            IδMinus δMinus,
            Interfaces.Variables.TP.WardSpareBeds.IδPlus δPlus_w,
            Interfaces.Variables.TP.WardBedOccupancyVariances.IVariance Variance_w);
    }
}