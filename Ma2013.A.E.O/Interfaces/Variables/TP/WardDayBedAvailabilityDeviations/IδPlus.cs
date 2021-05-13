namespace Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.CrossJoins.Common;
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations;
    using Ma2013.A.E.O.InterfacesFactories.Results.TP.WardDayBedAvailabilityDeviations;

    public interface IδPlus
    {
        VariableCollection<IwIndexElement, IdIndexElement> Value { get; }

        double GetElementAt(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement);

        Interfaces.Results.TP.WardDayBedAvailabilityDeviations.IδPlus GetElementsAt(
            IδPlusResultElementFactory δPlusResultElementFactory,
            IδPlusFactory δPlusFactory,
            Iwd wd);
    }
}