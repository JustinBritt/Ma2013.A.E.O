namespace Ma2013.A.E.O.Interfaces.Variables.TP.WardBedOccupancyVariances
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Indices.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardBedOccupancyVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardBedOccupancyVariances;

    public interface IVariance
    {
        VariableCollection<IwIndexElement> Value { get; }

        double GetElementAt(
            IwIndexElement wIndexElement);

        Interfaces.Results.TP.WardBedOccupancyVariances.IVariance GetElementsAt(
            IVarianceResultElementFactory VarianceResultElementFactory,
            IVarianceFactory VarianceFactory,
            Iw w);
    }
}