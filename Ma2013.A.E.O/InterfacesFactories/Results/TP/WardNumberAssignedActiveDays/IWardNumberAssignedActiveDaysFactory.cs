namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberAssignedActiveDays
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberAssignedActiveDays;

    public interface IWardNumberAssignedActiveDaysFactory
    {
        IWardNumberAssignedActiveDays Create(
            ImmutableList<IWardNumberAssignedActiveDaysResultElement> value);
    }
}