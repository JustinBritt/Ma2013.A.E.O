namespace Ma2013.A.E.O.InterfacesFactories.Constraints.SP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    public interface IConstraints5Factory
    {
        IConstraints5 Create(
            ImmutableList<IConstraints5ConstraintElement> value);
    }
}