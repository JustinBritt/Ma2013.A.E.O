namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.TP.SurgeonGroupNumberAssignedActiveDays;

    public interface ISurgeonGroupNumberAssignedActiveDaysResultElementFactory
    {
        ISurgeonGroupNumberAssignedActiveDaysResultElement Create(
            IsIndexElement sIndexElement,
            int value);
    }
}