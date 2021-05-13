namespace Ma2013.A.E.O.InterfacesFactories.Variables.TP.WardDayBedAvailabilityDeviations
{
    using OPTANO.Modeling.Optimization;

    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.Variables.TP.WardDayBedAvailabilityDeviations;

    public interface IδMinusFactory
    {
        IδMinus Create(
            VariableCollection<IwIndexElement, IdIndexElement> value);
    }
}