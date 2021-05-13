namespace Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementVariances
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementVariances;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementVariances;

    public interface IVariance
    {
        VariableCollection<IwIndexElement, IdIndexElement> Value { get; }

        double GetElementAt(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement);

        Interfaces.Results.TP.WardDayBedRequirementVariances.IVariance GetElementsAt(
            IVarianceResultElementFactory VarianceResultElementFactory,
            IVarianceFactory VarianceFactory,
            Iwd wd);
    }
}