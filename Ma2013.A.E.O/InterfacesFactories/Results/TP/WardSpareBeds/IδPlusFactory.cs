namespace Ma2013.A.E.O.InterfacesFactories.Results.TP.WardSpareBeds
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ResultElements.TP.WardSpareBeds;
    using Ma2013.A.E.O.Interfaces.Results.TP.WardSpareBeds;

    public interface IδPlusFactory
    {
        IδPlus Create(
            ImmutableList<IδPlusResultElement> value);
    }
}