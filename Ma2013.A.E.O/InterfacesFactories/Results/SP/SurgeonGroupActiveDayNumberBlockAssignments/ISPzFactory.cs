namespace Ma2013.A.E.O.InterfacesFactories.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.SurgeonGroupActiveDayNumberBlockAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.SurgeonGroupActiveDayNumberBlockAssignments;

    public interface ISPzFactory
    {
        ISPz Create(
            ImmutableList<ISPzResultElement> value);
    }
}