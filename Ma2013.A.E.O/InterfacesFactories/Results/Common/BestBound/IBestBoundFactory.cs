namespace Ma2013.A.E.O.InterfacesFactories.Results.Common.BestBound
{
    using Ma2013.A.E.O.Interfaces.Results.Common.BestBound;

    public interface IBestBoundFactory
    {
        IBestBound Create(
            decimal value);
    }
}