namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardNumberBedAssignments
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardNumberBedAssignments;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardNumberBedAssignments;

    public interface ITPyFactory
    {
        ITPy Create(
            ImmutableList<ITPyResultElement> value);
    }
}