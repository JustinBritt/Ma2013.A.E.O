namespace Ma2013.A.E.O.InterfacesFactories.Constraints.SP
{
    using System.Collections.Immutable;

    using Ma2013.A.E.O.Interfaces.ConstraintElements.SP;
    using Ma2013.A.E.O.Interfaces.Constraints.SP;

    public interface IConstraints6UFactory
    {
        IConstraints6U Create(
            ImmutableList<IConstraints6UConstraintElement> value);
    }
}