namespace Ma2013.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using Ma2013.A.E.O.Interfaces.IndexElements.Common;
    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    public interface ISPzResultElementFactory
    {
        ISPzResultElement Create(
            IsIndexElement sIndexElement,
            IaIndexElement aIndexElement,
            int value);
    }
}