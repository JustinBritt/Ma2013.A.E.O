namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardBedOccupancyVariances
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardBedOccupancyVariances;

    public interface IVarianceFactory
    {
        IVariance Create(
            VariableCollection<IwIndexElement> value);
    }
}