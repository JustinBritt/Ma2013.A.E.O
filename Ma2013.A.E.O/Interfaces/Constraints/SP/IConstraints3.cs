namespace Ma2013.A.E.O.Interfaces.Constraints.SP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;

    public interface IConstraints3
    {
        ImmutableList<IConstraints3ConstraintElement> Value { get; }
    }
}