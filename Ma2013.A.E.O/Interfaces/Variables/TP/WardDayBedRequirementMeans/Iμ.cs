namespace Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedRequirementMeans
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedRequirementMeans;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedRequirementMeans;

    public interface Iμ
    {
        VariableCollection<IwIndexElement, IdIndexElement> Value { get; }

        double GetElementAt(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement);

        Interfaces.Results.TP.WardDayBedRequirementMeans.Iμ GetElementsAt(
            IμResultElementFactory μResultElementFactory,
            IμFactory μFactory,
            Iwd wd);
    }
}