namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.SurgeonGroupNumberAssignedActiveDays
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;
    using Ma2013.A.E.O.Interfaces.Results.TP.SurgeonGroupNumberAssignedActiveDays;

    public interface ISurgeonGroupNumberAssignedActiveDaysFactory
    {
        ISurgeonGroupNumberAssignedActiveDays Create(
            ImmutableList<ISurgeonGroupNumberAssignedActiveDaysResultElement> value);
    }
}