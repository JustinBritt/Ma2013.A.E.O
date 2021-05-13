namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardDayBedAvailabilityDeviations
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardDayBedAvailabilityDeviations;

    public interface IδMinusResultElementFactory
    {
        IδMinusResultElement Create(
            IwIndexElement wIndexElement,
            IdIndexElement dIndexElement,
            decimal value);
    }
}