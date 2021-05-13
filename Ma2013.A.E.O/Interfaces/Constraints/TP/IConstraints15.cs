namespace Ma2013.A.E.O.Interfaces.Constraints.TP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.TP;

    public interface IConstraints15
    {
        ImmutableList<IConstraints15ConstraintElement> Value { get; }
    }
}