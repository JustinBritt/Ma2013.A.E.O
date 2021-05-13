namespace Ma2013.A.E.O.Interfaces.Constraints.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;

    public interface IConstraints12
    {
        ImmutableList<IConstraints12ConstraintElement> Value { get; }
    }
}