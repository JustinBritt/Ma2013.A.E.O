namespace Ma2013.A.E.O.InterfacesFactories.CrossJoins.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;
    using Ma2013.A.E.O.Interfaces.CrossJoins.TP;

    public interface IrkFactory
    {
        Irk Create(
            ImmutableList<IrkCrossJoinElement> value);
    }
}