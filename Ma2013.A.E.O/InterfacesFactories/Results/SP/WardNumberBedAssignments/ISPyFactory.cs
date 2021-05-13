namespace Ma2013.A.E.O.InterfacesFactories.Results.SP.WardNumberBedAssignments
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.SP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.SP.WardNumberBedAssignments;

    public interface ISPyFactory
    {
        ISPy Create(
            ImmutableList<ISPyResultElement> value);
    }
}