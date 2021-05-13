namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.DayExpectedBedShortages
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.DayExpectedBedShortages;
    using Ma2013.A.E.O.Interfaces.Results.TP.DayExpectedBedShortages;

    public interface IEBSFactory
    {
        IEBS Create(
            ImmutableList<IEBSResultElement> value);
    }
}