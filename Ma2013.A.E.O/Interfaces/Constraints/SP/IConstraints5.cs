namespace Ma2013.A.E.O.Interfaces.Constraints.SP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;

    public interface IConstraints5
    {
        ImmutableList<IConstraints5ConstraintElement> Value { get; }
    }
}