namespace Ma2013.A.E.O.Interfaces.CrossJoins.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.TP;

    public interface Isark
    {
        ImmutableList<IsarkCrossJoinElement> Value { get; }
    }
}