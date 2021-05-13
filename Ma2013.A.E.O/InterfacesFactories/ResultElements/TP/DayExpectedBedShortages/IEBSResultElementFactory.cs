namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.DayExpectedBedShortages
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;

    public interface IEBSResultElementFactory
    {
        IEBSResultElement Create(
            IdIndexElement dIndexElement,
            decimal value);
    }
}