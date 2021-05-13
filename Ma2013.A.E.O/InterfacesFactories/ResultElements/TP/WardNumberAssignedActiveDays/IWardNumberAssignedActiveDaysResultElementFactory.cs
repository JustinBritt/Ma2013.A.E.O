namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.WardNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;

    public interface IWardNumberAssignedActiveDaysResultElementFactory
    {
        IWardNumberAssignedActiveDaysResultElement Create(
            IwIndexElement wIndexElement,
            int value);
    }
}