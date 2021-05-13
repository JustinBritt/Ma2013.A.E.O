namespace Ma2013.A.E.O.Interfaces.CrossJoins.Common
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.CrossJoinElements.Common;

    public interface Ipa
    {
        ImmutableList<IpaCrossJoinElement> Value { get; }
    }
}